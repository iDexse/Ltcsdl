using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using DemoNewsPaper.Models;

namespace DemoNewsPaper.IO
{
    public class NewsRepository : INewsRepository
    {
        private const string FilePath = "data\\data.txt";

        List<Publisher> INewsRepository.GetNews()
        {
            var publisher = new List<Publisher>();
            Publisher office = null;
            string line;

            try
            {
                using (var stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            if (line.StartsWith("@"))
                            {
                                office = ParsePublisher(line);
                                publisher.Add(office);
                            }
                            else if (line.StartsWith("#") && office != null)
                            {
                                var category = ParseCategory(line);
                                office.Categories.Add(category);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return publisher;
        }

        private Category ParseCategory(string info)
        {
            var parts = info.Substring(1).Split('^');
            return new Category()
            {
                Name = parts[0].Trim(),
                RssLink = parts[1].Trim()
            };
        }


        private Publisher ParsePublisher(string info)
        {
            return new Publisher()
            {
                Name = info.Substring(1).Trim()
            };
        }
        public void Save(List<Publisher> publishers)
        {
            using (var stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var publisher in publishers)
                    {
                        writer.WriteLine("@{0}", publisher.Name);
                        foreach (var category in publisher.Categories)
                        {
                            writer.WriteLine("#{0}^{1}", category.Name, category.RssLink);
                        }
                    }
                }
            }
        }
    }
}

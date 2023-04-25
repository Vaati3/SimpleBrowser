using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Database
{
    public class Database
    {
        private XDocument xDocument;
        private string filename;

        public Database(ref string currentPage, string filename = "database.xml")
        {
            this.filename = filename;
            try
            {
                xDocument = XDocument.Load(filename);
            }
            catch
            {
                xDocument = new XDocument(
                    new XElement("Data",
                        new XElement("Home", "https://www.hw.ac.uk")
                    )
                );
            }
            currentPage = getHome();

            xDocument.Save(filename);
        }

        public string getHome()
        {
            return (xDocument.Elements("Data").Elements("Home").ElementAt(0).Value);
        }
        public void setHome(string uri)
        {
            xDocument.Elements("Data").Elements("Home").ElementAt(0).Value = uri;
            xDocument.Save(filename);
        }

        public XElement findFavorite(string uri)
        {
            foreach (XElement elem in xDocument.Elements("Data").Elements("Favorite").ToList())
            {
                if (elem.Elements("URI").ElementAt(0).Value == uri)
                    return elem;
            }
            return null;
        }

        public List<XElement> getFavorites()
        {
            return xDocument.Elements("Data").Elements("Favorite").ToList();
        }
        public List<XElement> getHistory()
        {
            return xDocument.Elements("Data").Elements("History").ToList();
        }

        public void addToHistory(string uri)
        {
            xDocument.Element("Data").AddFirst(
                new XElement("History", uri)
            );

            xDocument.Save(filename);
        }
        public void addToFavorites(string uri, string name)
        {
            XElement elem = findFavorite(uri);

            if (elem == null)
            {
                xDocument.Element("Data").AddFirst(
                    new XElement("Favorite",
                        new XElement("Name", name),
                        new XElement("URI", uri)
                    )
                );

                xDocument.Save(filename);
            }
            else
            {
                elem.Remove();
                xDocument.Save(filename);
            }
        }
    }
}
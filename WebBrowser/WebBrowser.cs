using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Request;
using System.Xml.Linq;

namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
        private Request.Request request;
        private Database.Database database;

        private string currentPage;
        public WebBrowser()
        {
            InitializeComponent();

            database = new Database.Database(ref currentPage);
            request = new Request.Request(currentPage);

            loadPage(currentPage);
            BtnFavor.BackgroundImage = database.findFavorite(currentPage) != null ? Properties.Resources.RemoveFavorite : Properties.Resources.AddFavorite;
            BtnHome.BackgroundImage = Properties.Resources.Home;
            BtnReload.BackgroundImage = Properties.Resources.Reload;

            database.getFavorites().ForEach(elem => {
                string tmp = elem.Elements("Name").ElementAt(0).Value + " " + elem.Elements("URI").ElementAt(0).Value;
                ListFavorites.Items.Add(tmp);
            });
            database.getHistory().ForEach(elem => {
                ListHistory.Items.Insert(0, elem.Value);
            });
        }

        private void loadPage(string uri)
        {
            uri = uri.ToLower();
            request.get(uri);
            string status = request.Title + " " + (int)request.Status + ": " + request.Status;
            currentPage = uri;
            Body.Text = request.Body;
            LabelStatus.Text = (int)request.Status + " " + request.Status;
            LabelTitle.Text = request.Title;
            SearchBar.Text = currentPage;
            BtnFavor.BackgroundImage = database.findFavorite(currentPage) != null ? Properties.Resources.RemoveFavorite : Properties.Resources.AddFavorite;
            ListHistory.Items.Insert(0, currentPage);
            database.addToHistory(uri);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (CheckBulk.Checked == true)
            {
                request.bulkDownload(SearchBar.Text);
                Body.Text = request.Bulk;
            } else
            {
                loadPage(SearchBar.Text);
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            loadPage(database.getHome());
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            loadPage(currentPage);
        }

        private void BtnFavor_Click(object sender, EventArgs e)
        {
            XElement favorite = database.findFavorite(currentPage);
            database.addToFavorites(currentPage, FavoritesName.Text);
            if (favorite != null)
            {
                ListFavorites.Items.Remove(favorite.Elements("Name").ElementAt(0).Value + " " + favorite.Elements("URI").ElementAt(0).Value);
                BtnFavor.BackgroundImage = Properties.Resources.AddFavorite;
            } else
            {
                ListFavorites.Items.Add(FavoritesName.Text + " " + currentPage);
                BtnFavor.BackgroundImage = Properties.Resources.RemoveFavorite;
            }
        }

        private void ListFavorites_Click(object sender, EventArgs e)
        {
            if (ListFavorites.SelectedItem != null)
            {
                loadPage(ListFavorites.SelectedItem.ToString().Split(' ').Last());
                ListFavorites.Visible = false;
            }
        }

        private void BtnFavorites_Click(object sender, EventArgs e)
        {
            ListHistory.Visible = false;
            ListFavorites.Visible = ListFavorites.Visible == true ? false : true;
        }

        private void ListHistory_Click(object sender, EventArgs e)
        {
            if (ListHistory.SelectedItem != null)
            {
                loadPage(ListHistory.SelectedItem.ToString());
                ListHistory.Visible = false;
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            ListFavorites.Visible = false;
            ListHistory.Visible = ListHistory.Visible == true ? false : true;
        }

        private void CheckBulk_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBulk.Checked == true)
            {
                Body.Text = request.Bulk;
                SearchBar.Text = "bulk.txt";
                BtnSearch.Text = "Bulk Download";
                PanelBrowserBtn.Visible = false;
                LabelStatus.Visible = false;
                LabelTitle.Visible = false;
            } else
            {
                Body.Text = request.Body;
                SearchBar.Text = currentPage;
                BtnSearch.Text = "Search";
                PanelBrowserBtn.Visible = true;
                LabelStatus.Visible = true;
                LabelTitle.Visible = true;
            }
        }

        private void BtnSetHome_Click(object sender, EventArgs e)
        {
            database.setHome(currentPage);
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.KeyPreview = true;
        }

        private void WebBrowser_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (int)System.Windows.Forms.Keys.F5:
                    loadPage(currentPage);
                    break;
                case (int)System.Windows.Forms.Keys.Home:
                    if (CheckBulk.Checked == false)
                    {
                        loadPage(database.getHome());
                    }
                    break;
                default:
                    break;
            }
        }

        private void SearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)System.Windows.Forms.Keys.Enter)
            {
                if (CheckBulk.Checked)
                {
                    request.bulkDownload(SearchBar.Text);
                    Body.Text = request.Bulk;
                }
                else
                {
                    loadPage(SearchBar.Text);
                }
            }
        }

        private void ListHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


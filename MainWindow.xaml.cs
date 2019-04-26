using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace BilateralNews
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GenerateBadNews();
            GenerateGoodNews();
        }

        private List<string> badNewsURLList = new List<string>();
        private List<string> badNewsDomainList = new List<string>();
        private List<string> goodNewsURLList = new List<string>();
        private List<string> goodNewsDomainList = new List<string>();


        private void GenerateBadNews()
        {
            var badNewsList = GatherNewsData.ReturnBadNewsData();
            int size = badNewsList.Count;


            for (int i = 0; i < size; i++)
            {
                badNewsListBox.Items.Add(badNewsList[i].Title.ToString());
                badNewsURLList.Add(badNewsList[i].NewsURL);
                badNewsDomainList.Add("https://www." + badNewsList[i].Domain);
            }
        }

        private void GenerateGoodNews()
        {
            var goodNewsList = GatherNewsData.ReturnGoodNewsData();
            int size = goodNewsList.Count;

            for (int i = 0; i < size; i++)
            {
                goodNewsListBox.Items.Add(goodNewsList[i].Title.ToString());
                goodNewsURLList.Add(goodNewsList[i].NewsURL);
                goodNewsDomainList.Add("https://www." + goodNewsList[i].Domain);
            }
        }

        private void BadNewsListBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int index = badNewsListBox.SelectedIndex;
            System.Diagnostics.Process.Start(badNewsURLList[index]);

            if (deleteAfterViewingCheckBox.IsChecked == true)
            { 
                badNewsListBox.Items.RemoveAt(index);
                badNewsURLList.RemoveAt(index);
                badNewsDomainList.RemoveAt(index);
            }
        }

        private void GoodNewsListBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int index = goodNewsListBox.SelectedIndex;
            System.Diagnostics.Process.Start(goodNewsURLList[index]);

            if (deleteAfterViewingCheckBox.IsChecked == true)
            {
                goodNewsListBox.Items.RemoveAt(index);
                goodNewsURLList.RemoveAt(index);
                goodNewsDomainList.RemoveAt(index);
            }
        }

        private void BadNewsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int index = badNewsListBox.SelectedIndex;
            try
            {
                fullTitleTextBlock.Text = badNewsListBox.SelectedItem.ToString();
                domainTextBox.Text = badNewsDomainList[index];
            }
            catch
            {
                fullTitleTextBlock.Text = "";
                domainTextBox.Text = "";
            }
        }

        private void GoodNewsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int index = goodNewsListBox.SelectedIndex;
            try
            {
                fullTitleTextBlock.Text = goodNewsListBox.SelectedItem.ToString();
                domainTextBox.Text = goodNewsDomainList[index];
            }
            catch
            {
                fullTitleTextBlock.Text = "";
                domainTextBox.Text = "";
            }
        }

        private void RandomSelectButton_Click(object sender, RoutedEventArgs e)
        {
            int maxIndex = badNewsURLList.Count;
            Random random = new Random();
            int randIndexInt = random.Next(0, maxIndex);
            int randNewsCategoryInt = random.Next(0, 10);
            string randomNewsArticleURL = string.Empty;

            if (randNewsCategoryInt % 2 == 0)
            {
                randomNewsArticleURL = badNewsURLList[randIndexInt];
            }
            else
            {
                randomNewsArticleURL = goodNewsURLList[randIndexInt];
            }

            System.Diagnostics.Process.Start(randomNewsArticleURL);

            if (deleteAfterViewingCheckBox.IsChecked == true)
            {
                if (randNewsCategoryInt % 2 == 0)
                {
                    badNewsListBox.Items.RemoveAt(randIndexInt);
                    badNewsURLList.RemoveAt(randIndexInt);
                    badNewsDomainList.RemoveAt(randIndexInt);
                }
                else
                {
                    goodNewsListBox.Items.RemoveAt(randIndexInt);
                    goodNewsURLList.RemoveAt(randIndexInt);
                    goodNewsDomainList.RemoveAt(randIndexInt);
                }
            }
        }

        private void RandomBadButton_Click(object sender, RoutedEventArgs e)
        {
            System.Random random = new System.Random();
            int randIndexInt = random.Next(0, badNewsURLList.Count);

            System.Diagnostics.Process.Start(badNewsURLList[randIndexInt]);

            if (deleteAfterViewingCheckBox.IsChecked == true)
            {
                badNewsListBox.Items.RemoveAt(randIndexInt);
                badNewsURLList.RemoveAt(randIndexInt);
                badNewsDomainList.RemoveAt(randIndexInt);
            }
        }

        private void RandomGoodButton_Click(object sender, RoutedEventArgs e)
        {
            System.Random random = new System.Random();
            int randIndexInt = random.Next(0, goodNewsURLList.Count);

            System.Diagnostics.Process.Start(goodNewsURLList[randIndexInt]);

            if (deleteAfterViewingCheckBox.IsChecked == true)
            {
                goodNewsListBox.Items.RemoveAt(randIndexInt);
                goodNewsURLList.RemoveAt(randIndexInt);
                goodNewsDomainList.RemoveAt(randIndexInt);
            }
        }

    }
}

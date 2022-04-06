using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.UseObserverPattern
{
    public class ArticlesDialogBox
    {
        private ListBox _articlesListBox = new ListBox();
        private TextBox _titleTextBox = new TextBox();
        private Button _saveButton = new Button();
        public ArticlesDialogBox()
        {
            //_articlesListBox.AddEventHandler(ArticleSelected);
            //_titleTextBox.AddEventHandler(TitleChanged());
        }

        public void SimulateUserInteraction()
        {
            _articlesListBox.SetSelection("Article 1");
            Console.WriteLine($"Textbox: {_titleTextBox.GetContent()}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled()}");
            Console.WriteLine("\b");
            _titleTextBox.SetContent(string.Empty);
            Console.WriteLine($"Textbox: {_titleTextBox.GetContent()}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled()}");
            Console.WriteLine("\b");
            _titleTextBox.SetContent("Article 2");
            Console.WriteLine($"Textbox: {_titleTextBox.GetContent()}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled()}");
        }
        private void ArticleSelected()
        {
            _titleTextBox.SetContent(_articlesListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }
        private void TitleChanged()
        {
            var content = _titleTextBox.GetContent();
            var isEmpty = (content == null || content.Length == 0);
            _saveButton.SetEnabled(!isEmpty);
        }
    }
}

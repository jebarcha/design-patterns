using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox _articlesListBox; // = new ListBox(this);
        private TextBox _titleTextBox; //= new TextBox();
        private Button _saveButton; //= new Button();

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
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
        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
            {
                ArticleSelected();
            }
            else if (control == _titleTextBox)
            {
                TitleChanged();
            }
            
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

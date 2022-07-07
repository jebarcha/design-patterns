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
        //public delegate void IEventHandler ();

        public ArticlesDialogBox()
        {
            //IEventHandler x = () => ArticleSelected();
            //x();
            //_articlesListBox.AddEventHandler(x);

            var myAnonyClassObject = new { Name = "Abhimanyu", Age = 21 };

            //_articlesListBox.AddEventHandler(  new IEventHandler()
            //{
            //    public override void Handle()
            //    {
            //        ArticleSelected();
            //    }
            //});

            //var x = new System.Dynamic.DynamicObject(new
            //{
            //}).ArticleSelected<IEventHandler>();

            //var developer = new { Name = "Jason Bowers" };
            //_articlesListBox.AddEventHandler(developer.Handler<IEventHandler>());


            //_articlesListBox.AddEventHandler(ArticleSelected);
            //_titleTextBox.AddEventHandler(TitleChanged());
        }
        public static T Handler<T>(this object subject) where T : class
        {
            return null;
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

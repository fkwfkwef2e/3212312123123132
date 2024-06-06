using System;
using System.Windows;
using SerializationLibrary;
namespace _3212312123123132
{
    public partial class MainWindow : Window
    {
        private readonly Serializer<Person> _serializer; 

        public MainWindow()
        {
            InitializeComponent();
            _serializer = new Serializer<Person>(); 
        }

        private void BtnSerialize_Click(object sender, RoutedEventArgs e)
        {
            var person = new Person
            {
                Name = TbxName.Text,
                Age = int.Parse(TbxAge.Text)
            };

            _serializer.Serialize(person, "person.json"); 
            MessageBox.Show("Данные успешно сериализованы!");
        }

        private void BtnDeserialize_Click(object sender, RoutedEventArgs e)
        {
            var person = _serializer.Deserialize("person.json"); 

            TbxName.Text = person.Name;
            TbxAge.Text = person.Age.ToString();
            MessageBox.Show("Данные успешно десериализованы!");
        }
    }
}
}

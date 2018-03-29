using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstractions;

namespace HavingFunWithSerializators
{
    public partial class CarsForm : Form
    {
        private readonly List<IMySerializer> _serializers = new List<IMySerializer>();

        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            carsDataGridView.DataSource = CarsDataProvider.GetCars();
            RefreshSerializers();
        }

        private void RefreshSerializers()
        {
            _serializers.Clear();
            LoadAllBinDirectoryAssemblies();
            var mySerializerType = typeof(IMySerializer);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => mySerializerType.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract)
                .ToList();

            foreach (var type in types)
            {
                _serializers.Add((IMySerializer)Activator.CreateInstance(type));

            }

            serializerTypeComboBox.DataSource = _serializers.Select(s => s as INamed).Select(s => s.FriendlyName).ToList();
        }

        public static void LoadAllBinDirectoryAssemblies()
        {
            var binPath = Path.Combine("D://serz");

            foreach (string dll in Directory.GetFiles(binPath, "*.dll", SearchOption.AllDirectories))
            {
                try
                {
                    Assembly.LoadFile(dll);
                }
                catch (FileLoadException loadEx)
                { } // The Assembly has already been loaded.
                catch (BadImageFormatException imgEx)
                { } // If a BadImageFormatException exception is thrown, the file is not an assembly.

            } // foreach dll
        }

        private void refreshSerializersButton_Click(object sender, EventArgs e)
        {
            RefreshSerializers();
        }

        private void saveAllButton_Click(object sender, EventArgs e)
        {

        }

        private void loadFromButton_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Abstractions;
using Cars;

namespace HavingFunWithSerializators
{
    public partial class CarsForm : Form
    {
        private readonly List<IMySerializer> _serializers = new List<IMySerializer>();
        private List<Car> _cars;

        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            _cars = CarsDataProvider.GetCars();
            RefreshCarsDataSource();
            RefreshSerializers();
        }

        private void RefreshSerializers()
        {
            _serializers.Clear();

            DllHelper.LoadAllBinDirectoryAssemblies();
            var types = DllHelper.GetTypes(typeof(IMySerializer));

            foreach (var type in types)
            {
                _serializers.Add((IMySerializer)Activator.CreateInstance(type));
            }

            serializerTypeComboBox.DataSource = _serializers.Select(s => s as INamed).Select(s => s.FriendlyName).ToList();
        }


        private void refreshSerializersButton_Click(object sender, EventArgs e)
        {
            RefreshSerializers();
        }

        private void saveAllButton_Click(object sender, EventArgs e)
        {
            if (saveToLoadFromDialog.ShowDialog() == DialogResult.OK)
            {
                ChosenSerializer.Serialize(_cars, saveToLoadFromDialog.FileName);
            }
        }

        private void loadFromButton_Click(object sender, EventArgs e)
        {
            if (saveToLoadFromDialog.ShowDialog() == DialogResult.OK)
            {
                _cars = ChosenSerializer.Deserialize<List<Car>>(saveToLoadFromDialog.FileName);
                RefreshCarsDataSource();
            }
        }

        private void RefreshCarsDataSource()
        {
            carsDataGridView.DataSource = new BindingSource(new BindingList<Car>(_cars), null);
            carsDataGridView.Refresh();
        }

        private IMySerializer ChosenSerializer => _serializers
            .First(s => (s as INamed)?.FriendlyName == serializerTypeComboBox.SelectedValue);
    }
}

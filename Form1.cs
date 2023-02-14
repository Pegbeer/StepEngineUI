using System.IO.Ports;

namespace StepEngineUI
{
    public partial class Form1 : Form
    {
        private ViewModel _viewModel = new();
        private SerialPort _port = new();

        public Form1()
        {
            InitializeComponent();
            _viewModel.Contador = 0;
            InitPort();
            InitViews();
        }

        private void InitViews()
        {
            lblContador.DataBindings.Add("Text", _viewModel, "Contador");
        }

        private void InitPort()
        {
            _port.BaudRate = 9600;
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (!_port.IsOpen)
            {
                MessageBox.Show("Debe conectarse primero al Puerto COM");
                return;
            }

            if (_viewModel.Contador == 0)
            {
                MessageBox.Show("No puede ser menor a 0");
                return;
            }

            _viewModel.Contador -= 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxPortName.Text))
            {
                MessageBox.Show("Nombre de puerto vacio");
                return;
            }

            
            try
            {
                _port.PortName = txtBoxPortName.Text;
                _port.Open();
                if(_port.IsOpen )
                {
                    MessageBox.Show("Conectado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Nombre de puerto invalido");
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (!_port.IsOpen)
            {
                MessageBox.Show("Debe conectarse primero al Puerto COM");
                return;
            }

            if (_viewModel.Contador == 4)
            {
                MessageBox.Show("No puede ser mayor a 4");
                return;
            }

            _viewModel.Contador += 1;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidarConexion())
            {
                MessageBox.Show("Debe conectarse primero al Puerto COM");
                return;
            }

            _port.Write(_viewModel.Contador.ToString());
            _port.Close();
        }

        private bool ValidarConexion()
        {
            return _port.IsOpen;
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (_port.IsOpen) _port.Close();
        }
    }
}
namespace BridgeProject
{
    public partial class BridgeMainForm : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private ShapeBridge[] bridges;
        public BridgeMainForm()
        {
            InitializeComponent();
            CbShapeKind.Items.AddRange(ShapeFactory.Keys);
            CbShapeKind.SelectedItem = 0;
            bridges = new ShapeBridge[]
            {
                new ShapeBridgeToListBox(listBox1),
                new ShapeBridgeToPictureBox(PbShape),
                new ShapeBridgeToXMLTextBox(TbXML),
            };
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string kind=CbShapeKind.SelectedItem.ToString();
            string parameters=tbParameters.Text;
            Shape shape= ShapeFactory.make(kind, parameters);
            shapes.Add(shape);
            foreach (var bridge in bridges)
            {
                bridge.proceed(shapes);
            }
        }
    }
}

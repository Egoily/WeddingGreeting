using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EgoDevil.Utilities.UI.EPanels
{
    /// <summary>
    /// Represents a splitter control that enables the user to resize docked controls.
    /// </summary>
    /// <remarks>
    /// The splitter control supports in difference to the <see
    /// cref="System.Windows.Forms.Splitter"/> the using of a transparent backcolor.
    /// </remarks>

    [DesignTimeVisible(true)]
    [ToolboxBitmap(typeof(Splitter))]
    public partial class ESplitter : Splitter
    {
        #region MethodsPublic

        /// <summary>
        /// Initializes a new instance of the Splitter class.
        /// </summary>
        public ESplitter()
        {
            //The System.Windows.Forms.Splitter doesn't suports a transparent backcolor
            //With this, the using of a transparent backcolor is possible
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        #endregion
    }
}
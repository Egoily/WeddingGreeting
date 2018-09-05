using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingGreeting.UserControls
{
    public partial class TableControl : UserControl
    {
        private string tableName;
        public string TableName
        {
            get => tableName;
            set
            {
                if (tableName != value)
                {
                    tableName = value;
                    this.Invalidate();
                }
            }
        }
        private string tableNo;
        public string TableNo
        {
            get => tableNo;
            set
            {
                if (tableNo != value)
                {
                    tableNo = value;
                    this.Invalidate();
                }
            }
        }

        private List<string> names = new List<string>();
        public List<string> Names
        {
            get => names;
            set
            {
                if (names != value)
                {
                    names = value;
                    this.Invalidate();
                }
            }
        }

        public TableControl()
        {
            InitializeComponent();
        }

        private void TableControl_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            #region 画圆
            Pen pen = new Pen(Color.Pink, 4);//画笔颜色                                
            g.DrawEllipse(pen, new Rectangle(0, 0, Width, Height));//画椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
            #endregion

            #region 画桌名与桌号
            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,  // 垂直居中
                Alignment = StringAlignment.Center      // 水平居中
            };
            Font myFont = new Font("宋体", 10, FontStyle.Bold);

            Brush bush = new SolidBrush(Color.Red);//填充的颜色

            g.DrawString(TableName + "\n" + TableNo, myFont, bush, new Rectangle(0, 0, Width, Height), format);

            #endregion
            names.Clear();
            names.Add("黄广毅");
            names.Add("黄广毅");
            names.Add("黄广毅");
            names.Add("黄广毅");
            names.Add("黄广毅");
            names.Add("黄广毅");
            names.Add("黄广毅");
            names.Add("黄广毅");
            names.Add("黄广毅");
            names.Add("黄广毅");


            int r = Width > Height ? Height / 2 : Width / 2;
            var angle = 360 / names.Count;
            //if (names != null && names.Count > 0)
            //{
            //    for (var i = 0; i < names.Count; i++)
            //    {
            //        g.ResetTransform();
            //        g.TranslateTransform(Width / 2, Height / 2); //更改坐标原点
            //        g.RotateTransform(i * angle);  //旋转
            //        g.DrawString(names[i], myFont, bush, r-50, 0);
            //    }
            //}
            //g.ResetTransform();


            g.TranslateTransform(r, r);
            if (names != null && names.Count > 0)
            {
                for (var i = 0; i < names.Count; i++)
                {
                    using (var p = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        //g.DrawLine(Pens.Black, 0, 0, r, 0);
                        p.AddString(names[i], new FontFamily("宋体"), 1, 10, new Point(r-50, 0), new StringFormat());
                        if (i * angle > 90 && i * angle < 270)
                        {
                            p.Transform(new System.Drawing.Drawing2D.Matrix(-1, 0, 0, -1, 150, 0));
                        }
                        g.FillPath(Brushes.Black, p);
                        g.RotateTransform(angle);
                    }
                }
            }


            //g.ResetTransform();
            //g.TranslateTransform(r, r);
            //for (var a = 0; a < 360; a += angle)
            //{
            //    using (var p = new System.Drawing.Drawing2D.GraphicsPath())
            //    {
            //        //g.DrawLine(Pens.Black, 0, 0, 140, 0);
            //        p.AddString("方向角" + a, new FontFamily("宋体"), 1, 10, new Point(50, 2), new StringFormat());
            //        if (a > 90 && a < 270)
            //        {
            //            p.Transform(new System.Drawing.Drawing2D.Matrix(-1, 0, 0, -1, 150, 0));
            //        }
            //        g.FillPath(Brushes.Black, p);
            //        g.RotateTransform(angle);
            //    }
            //}
        }
    }
}

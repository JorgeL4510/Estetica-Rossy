using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;

namespace Estetica_Rossy
{
    public partial class Reporte : Form
    {
        internal CrystalDecisions.CrystalReports.Engine.ReportDocument ReportExporta;
        public Reporte()
        {
            InitializeComponent();
        }


        private void Reporte_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = ReportExporta;
        }
    }
}

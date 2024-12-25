﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        EgitimKampiTravelDbEntities db = new EgitimKampiTravelDbEntities();

        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();

            lblAvgCapacity.Text = db.Location.Average(x => (double?)x.Capacity)?.ToString("F2") ?? "0.00";
            lblAvgLocationPrice.Text = db.Location.Average(x => (double?)x.Pirce)?.ToString("F2") + " ₺" ?? "0.00";

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCapadocciaLocationCapacity.Text = db.Location.Where(x => x.City == "Antalya").Select(y => (double?)y.Capacity).FirstOrDefault()?.ToString("F2") ?? "0.00";

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => (double?)y.Capacity)?.ToString("F2") ?? "0.00";

            var ParisGuideId = db.Location.Where(x => x.City == "Paris").Select(y => y.GuideId).FirstOrDefault();
            lblParisGuideName.Text = db.Guide.Where(x => x.GuideId == ParisGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();

            var maxCapacityLocaiton = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacityLocaiton).Select(y => y.City).FirstOrDefault().ToString();

            var maxPriceLocation = db.Location.Max(x => x.Pirce);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Pirce == maxPriceLocation).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
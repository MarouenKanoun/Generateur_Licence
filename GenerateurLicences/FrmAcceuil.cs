using DevExpress.XtraEditors;
using GenerateurLicences.data.Cmd;
using GenerateurLicences.Localisation;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GenerateurLicences
{
    public partial class FrmAcceuil : XtraForm
    {
        bool IsLicenced = false;
        public FrmAcceuil()
        {
            InitializeComponent();
        }
        private void Sauvgarder_Click(object sender, EventArgs e)
        {
            try
            {
                ProgramManager.InserstionData(CmdLicenceLoad.LoadDataToDataBase(DateDebutLicenece.Text, DateFin.Text, ImputLicences.Text, NombreDeJour.Text, CodeClient.Text, GropLicences.Properties.Items[GropLicences.SelectedIndex].Description));
                AlimenterGrid.FillDataGridView<Client>(GcLicence, ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient()), ProgramManager.Chargement(ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient())));
                MsgBox.Show(this, MessagesSystem.LoadDataSucced + NomClient.Text);
                if (ImputLicences.Text == MessagesSystem.StringVide)
                {
                    MsgBox.Show(this, MessagesSystem.StringVide);
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show(this, ex.Message);
            }
        }
        private void GenererLicence_Click(object sender, EventArgs e)
        {
            if (ProgramManager.DetecteurErreurSaisieNewClient(NomClient, CodeClient, CodePostale, Adresse1) == true)
            {
                FixRadioGroup();
                string licences = GetLicences.GetSeriale(NomClient, CodeClient, CodePostale, Adresse1, GropLicences);
                ImputLicences.Text = licences;
                DateDebutLicenece.Text = DateTime.Today.ToString("dd-MM-yyyy");
                DateFin.Text = Convert.ToDateTime(LicenceDelaisManager.FinLicence(DateTime.Today, LicenceDelaisManager.LicenceLength(GropLicences.Properties.Items[GropLicences.SelectedIndex].Description))).ToString("dd-MM-yyyy");
                NombreDeJour.Text = LicenceDelaisManager.LicenceLength(GropLicences.Properties.Items[GropLicences.SelectedIndex].Description).ToString();
                ProgramManager.InserstionData(CmdLicenceLoad.UpdateDataClient(NomClient,CodeClient,CodePostale,VilleClient,Adresse1,Adresse2, GropLicences));

                ProgramManager.InserstionData(CmdLicenceLoad.LoadDataToDataBase(DateDebutLicenece.Text, DateFin.Text, ImputLicences.Text, NombreDeJour.Text, CodeClient.Text, GropLicences.Properties.Items[GropLicences.SelectedIndex].Description));
                AlimenterGrid.FillDataGridView<Client>(GcLicence, ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient()), ProgramManager.Chargement(ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient())));
                FindInGridControl(CodeClient.Text);
                NomClient.ResetText(); CodeClient.ResetText(); CodePostale.ResetText();
                VilleClient.ResetText(); Adresse1.ResetText(); Adresse2.ResetText();
                DateDebutLicenece.ResetText(); DateFin.ResetText();
                ImputLicences.ResetText(); NombreDeJour.ResetText();
                MsgBox.Show(this, MessagesSystem.ModifSaved);
            }
            else
            {
                MsgBox.Show(this, MessagesSystem.ErreurAjoutClientExpress);
            }
        }
        public void FindInGridControl(string _CodeCient)
        {
            for (int index = 0; index < GvLicence.RowCount; index++)
            {
                if (GvLicence.GetRowCellValue(index, ClientCode).ToString() == _CodeCient)
                {
                    GvLicence.FocusedRowHandle = index;
                    GvLicence.SetRowCellValue(index, ClientCode, _CodeCient);
                    return;
                }
            }
            MsgBox.Show(this, "Not Found");
        }
        private void BoutonDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsLicenced)
                {
                    if (CodeClient.Text != String.Empty)
                    {
                        FrmDetails Details = new FrmDetails();
                        Details.ShowInTaskbar = false;
                        Details.ClientCode = CodeClient.Text;
                        if (Details.ClientCode != "")
                        {
                            Details.Dialog = true;
                            Details.ShowDialog();
                            Details.ClientCode = "";
                            AlimenterGrid.FillDataGridView<Client>(GcLicence, ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient()), ProgramManager.Chargement(ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient())));
                            FindInGridControl(CodeClient.Text);
                            NomClient.ResetText(); CodeClient.ResetText(); CodePostale.ResetText();
                            VilleClient.ResetText(); Adresse1.ResetText(); Adresse2.ResetText();
                        }
                        else
                        {
                            CodeClient.BackColor = Color.Red;
                            Details.Dispose();
                            return;
                        }
                    }
                    else
                    {
                        MsgBox.Show(this, MessagesSystem.ErreurAjoutClientExpress);
                        CodeClient.BackColor = Color.Red;
                    }
                }
                else
                {
                    MsgBox.Show(this, "User Not Licenced !!!");
                    return;
                }

            }
            catch (Exception ex)
            {
                MsgBox.Show(this, ex.Message);
            }
        }
        private void ButtonAjout_Click(object sender, EventArgs e)
        {
            try
            {

                if (ProgramManager.DetecteurErreurSaisieNewClient(NomClient, CodeClient, CodePostale, Adresse1) == true)
                {
                    ProgramManager.InsertClientRapide(CmdClient.RequetAjoutClientRapide(CodeClient.Text, Adresse1.Text, Adresse2.Text, CodePostale.Text, VilleClient.Text, NomClient.Text));
                    AlimenterGrid.FillDataGridView<Client>(GcLicence, ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient()), ProgramManager.Chargement(ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient())));
                    MsgBox.Show(this, MessagesSystem.ClientAddSuccecful);
                }
                else
                {
                    MsgBox.Show(this, MessagesSystem.ErreurAjoutClientExpress);
                }
            }
            catch (Exception EX)
            {
                MsgBox.Show(this, EX.Message);
            }
        }
        private void GropLicences_SelectedIndexChanged(object sender, EventArgs e)
        {
            FixRadioGroup();
            NombreDeJour.ResetText();
            DateDebutLicenece.ResetText();
            DateFin.ResetText();
            ImputLicences.ResetText();
        }
        private void GvLicence_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ProgramManager.RecupererElementRow(CodeClient, GvLicence, "ClientCode");
            ProgramManager.RecupererElementRow(NomClient, GvLicence, "ClientPrenom");
            ProgramManager.RecupererElementRow(CodePostale, GvLicence, "ClientCodePostal");
            ProgramManager.RecupererElementRow(Adresse1, GvLicence, "ClientAdresse1");
            ProgramManager.RecupererElementRow(Adresse2, GvLicence, "ClientAdresse2");
            ProgramManager.RecupererElementRow(VilleClient, GvLicence, "ClientVille");
            IsLicenced= ProgramManager.RecupererElementRow(GropLicences, PicLicence1, PicLicence2, PicLicence3, GvLicence, "TypeLicences");
        }
        private void FrmAcceuil_Shown(object sender, EventArgs e)
        {
            ImageList il = new ImageList();
            il.Images.Add(Properties.Resources.Licence1);
            il.Images.Add(Properties.Resources.Licence2);
            il.Images.Add(Properties.Resources.Licence3);
            LicImageCombo.SmallImages = il;
            LicImageCombo.Items.Add("Licence1", "Licence1", 0);
            LicImageCombo.Items.Add("Licence2", "Licence2", 1);
            LicImageCombo.Items.Add("Licence3", "Licence3", 2);
            AlimenterGrid.FillDataGridView<Client>(GcLicence, ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient()), ProgramManager.Chargement(ProgramManager.Chargementreader(CmdClient.RequetteCaracteristiqueClient())));
        }
        private void RadioModeNormale_CheckedChanged(object sender, EventArgs e)
        {
            ProgramManager.SetModeNormale(GcLicence, PicLicence1, PicLicence2, PicLicence3, NomClient, CodeClient, CodePostale, VilleClient, Adresse1,
                Adresse2, GropLicences, GenererLicence, ImputLicences, DateDebutLicenece, DateFin,
                NombreDeJour, Sauvgarder, BoutonDetails, ButtonAjout);
        }
        private void RadioConsulterDetails_CheckedChanged(object sender, EventArgs e)
        {
            ProgramManager.DetailsLicence(GcLicence, PicLicence1, PicLicence2, PicLicence3, NomClient, CodeClient, CodePostale, VilleClient, Adresse1,
                Adresse2, GropLicences, GenererLicence, ImputLicences, DateDebutLicenece, DateFin,
                NombreDeJour, Sauvgarder, BoutonDetails, ButtonAjout);
        }
        private void AjoutClientExpress_CheckedChanged(object sender, EventArgs e)
        {
            ProgramManager.AjoutExppress(GcLicence, PicLicence1, PicLicence2, PicLicence3, NomClient, CodeClient, CodePostale, VilleClient, Adresse1,
            Adresse2, GropLicences, GenererLicence, ImputLicences, DateDebutLicenece, DateFin,
            NombreDeJour, Sauvgarder, BoutonDetails, ButtonAjout);
        }
        private void SplitContainerControl1_Paint(object sender, PaintEventArgs e)
        {
            splitContainerControl1.Panel1.MinSize = 365;
            splitContainerControl1.Panel2.MinSize = splitContainerControl1.Width - 365;
        }
        private void PicLicence3_Click(object sender, EventArgs e)
        {
            GropLicences.SelectedIndex = 2;
        }
        private void PicLicence2_Click(object sender, EventArgs e)
        {
            GropLicences.SelectedIndex = 1;
        }
        private void PicLicence1_Click(object sender, EventArgs e)
        {
            GropLicences.SelectedIndex = 0;
        }
        private void AcceuilTextChanged(object sender, EventArgs e)
        {
            if ((sender as TextEdit).Text.Trim().Length == 1)
            {
                (sender as TextEdit).BackColor = Color.White;
            }
        }
        private void CodeClient_KeyUp(object sender, KeyEventArgs e)
        {
            for (int index = 0; index < GvLicence.RowCount; index++)
            {
                if (GvLicence.GetRowCellValue(index, ClientCode).ToString() == CodeClient.Text)
                {
                    GvLicence.FocusedRowHandle = index;
                    GvLicence.SetRowCellValue(index, ClientCode, CodeClient.Text);
                    IsLicenced = DetailsRepository.DefractionnerObjetReaderClient(ProgramManager.RecupDataClient(CodeClient.Text), PicLicence1, PicLicence2, PicLicence3, NomClient, CodePostale, VilleClient, Adresse1, Adresse2, GropLicences);
                    return;
                }
            }
            GvLicence.MoveFirst();
        }
        void FixRadioGroup()
        {
            if (GropLicences.Properties.Items[GropLicences.SelectedIndex].Description == "Licence1")
            {
                GropLicences.Properties.Appearance.BackColor = Color.Lime;
                GropLicences.Properties.AppearanceDisabled.BackColor = Color.Lime;
                PicLicence1.BackColor = Color.Lime;
                GropLicences.Properties.AppearanceFocused.BackColor = Color.Lime;
                PicLicence2.BackColor = Color.Lime;
                GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Lime;
                PicLicence3.BackColor = Color.Lime;
            }
            else if (GropLicences.Properties.Items[GropLicences.SelectedIndex].Description == "Licence2")
            {
                GropLicences.Properties.Appearance.BackColor = Color.Gold;
                GropLicences.Properties.AppearanceDisabled.BackColor = Color.Gold;
                PicLicence1.BackColor = Color.Gold;
                GropLicences.Properties.AppearanceFocused.BackColor = Color.Gold;
                PicLicence2.BackColor = Color.Gold;
                GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Gold;
                PicLicence3.BackColor = Color.Gold;
            }
            else if (GropLicences.Properties.Items[GropLicences.SelectedIndex].Description == "Licence3")
            {
                GropLicences.Properties.Appearance.BackColor = Color.Aqua;
                GropLicences.Properties.AppearanceDisabled.BackColor = Color.Aqua;
                PicLicence1.BackColor = Color.Aqua;
                GropLicences.Properties.AppearanceFocused.BackColor = Color.Aqua;
                PicLicence2.BackColor = Color.Aqua;
                GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Aqua;
                PicLicence3.BackColor = Color.Aqua;
            }
        }
    }
}
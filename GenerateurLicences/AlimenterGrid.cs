using System.Collections.Generic;
using DevExpress.XtraGrid;

namespace GenerateurLicences
{
    /// <summary>
    /// classe permet d'alimenter le data grid
    /// </summary>
    public static class AlimenterGrid
    {
        #region ..methodes diverses..

        /// <summary>
        /// Méthode permettant d'alimenter un Datagrid avec une source de donnée
        /// </summary>
        /// <param name="xGridControl">GridControl</param>
        /// <param name="gridView">GridView</param>
        /// <param name="dataSource">Liste de donnée</param>
        public static void FillDataGridView<T>(GridControl GridControl, object dataSource, List<T> Liste) where T : class
        {
            if (Liste != null)
            {
                GridControl.DataSource = Liste;
            }
            else
            {
                GridControl.DataSource = dataSource;
            }
        }

        #endregion
    }
}

using System.Web.Mvc;

namespace GestionDeStockCusHabitat
{
    public class FilterConfig
    {
        /// <summary>
        /// Permet de filtrer l'acccès a certaines méthodes, vues etc
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

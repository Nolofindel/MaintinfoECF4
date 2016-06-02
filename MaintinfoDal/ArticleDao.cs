using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
namespace MaintinfoDal
{
    [Serializable]
    public class ArticleDao
    {
        public static Article RecupererArticle(string DesignationArticle)
        {
            Article art = new Article();
            return art;
        }
        public static void MaJArticle(Article art)
        {

        }
    }
}

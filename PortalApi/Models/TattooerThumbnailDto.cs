using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class TattooerThumbnailDto
    {
        public int Id { get; set; }
        public string Studio { get; set; }
        public UserShortDto User { get; set; }

        // TODO: 4 zdjecia dla jednego tattooer'a w widoku tattooerów 
        // filtrowanie po plec technika styl miasto
        // WYSWIETLANE: 
        // 3 Profile w 10 wierszach
        /* ______  ______   ______
           |    |  |    |   |    |
           |    |  |    |   |    |
           |____|  |____|   |____|
           ______  ______   ______
           |    |  |    |   |    |
           |    |  |    |   |    |
           |____|  |____|   |____|
           ______  ______   ______
           |    |  |    |   |    |
           |    |  |    |   |    |
           |____|  |____|   |____|

        */

    }
}

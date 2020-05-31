using PortalApi.Enums;
using PortalApi.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Validators
{
    public class ResourceValidator : IResourceValidator
    {
        public bool ValidArticlesParameters(ArticlesResourceParameters articlesResourceParameters)
        {
            if (articlesResourceParameters.PageSize <= 0)
                return false;

            if (articlesResourceParameters.PageNumber <= 0)
                return false;

            return true;
        }

        public bool ValidPiercingsParameters(PiercingsResourceParameters piercingsResourceParameters)
        {
            if (piercingsResourceParameters.PageSize <= 0)
                return false;

            if (piercingsResourceParameters.PageNumber <= 0)
                return false;

            if (piercingsResourceParameters.Puncture != null)
            {
                if (!Enum.TryParse(piercingsResourceParameters.Puncture.Trim(), out Puncture puncture))
                    return false;
            }

            if (piercingsResourceParameters.Gender != null)
            {
                if (!Enum.TryParse(piercingsResourceParameters.Gender.Trim(), out Gender gender))
                    return false;
            }

            return true;
        }

        public bool ValidTattoosParameters(TattoosResourceParameters tattoosResourceParameters)
        {
            if (tattoosResourceParameters.PageSize <= 0)
                return false;

            if (tattoosResourceParameters.PageNumber <= 0)
                return false;

            if (tattoosResourceParameters.Style != null)
            {
                if (!Enum.TryParse(tattoosResourceParameters.Style.Trim(), out Style style))
                    return false;
            }

            if (tattoosResourceParameters.Color != null)
            {
                if (!Enum.TryParse(tattoosResourceParameters.Color.Trim(), out Color color))
                    return false;
            }

            if (tattoosResourceParameters.Technique != null)
            {
                if (!Enum.TryParse(tattoosResourceParameters.Technique.Trim(), out Technique technique))
                    return false;
            }

            if (tattoosResourceParameters.Gender != null)
            {
                if (!Enum.TryParse(tattoosResourceParameters.Gender.Trim(), out Gender gender))
                    return false;
            }

            return true;
        }
    }
}

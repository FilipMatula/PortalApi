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

            if (piercingsResourceParameters.Punctures != null)
            {
                foreach (var punctureString in piercingsResourceParameters.Punctures)
                {
                    if (!Enum.TryParse(punctureString.Trim(), out Puncture puncture))
                        return false;
                }
            }

            if (piercingsResourceParameters.Genders != null)
            {
                foreach (var genderString in piercingsResourceParameters.Genders)
                {
                    if (!Enum.TryParse(genderString.Trim(), out Gender gender))
                        return false;
                }
            }

            return true;
        }

        public bool ValidTattoosParameters(TattoosResourceParameters tattoosResourceParameters)
        {
            if (tattoosResourceParameters.PageSize <= 0)
                return false;

            if (tattoosResourceParameters.PageNumber <= 0)
                return false;

            if (tattoosResourceParameters.Styles != null)
            {
                foreach (var styleString in tattoosResourceParameters.Styles)
                {
                    if (!Enum.TryParse(styleString.Trim(), out Style style))
                        return false;
                }
            }

            if (tattoosResourceParameters.Colors != null)
            {
                foreach (var colorString in tattoosResourceParameters.Colors)
                {
                    if (!Enum.TryParse(colorString.Trim(), out Color color))
                        return false;
                }
            }

            if (tattoosResourceParameters.Techniques != null)
            {
                foreach (var techniqueString in tattoosResourceParameters.Techniques)
                {
                    if (!Enum.TryParse(techniqueString.Trim(), out Technique style))
                        return false;
                }
            }

            if (tattoosResourceParameters.Genders != null)
            {
                foreach (var genderString in tattoosResourceParameters.Genders)
                {
                    if (!Enum.TryParse(genderString.Trim(), out Gender gender))
                        return false;
                }
            }

            return true;
        }

        public bool ValidDesignsParameters(AvailableDesignPhotoResourceParameters availableDesignsResourceParameters)
        {
            if (availableDesignsResourceParameters.PageSize <= 0)
                return false;

            if (availableDesignsResourceParameters.PageNumber <= 0)
                return false;

            if (availableDesignsResourceParameters.Styles != null)
            {
                foreach (var styleString in availableDesignsResourceParameters.Styles)
                {
                    if (!Enum.TryParse(styleString.Trim(), out Style style))
                        return false;
                }
            }

            if (availableDesignsResourceParameters.Colors != null)
            {
                foreach (var colorString in availableDesignsResourceParameters.Colors)
                {
                    if (!Enum.TryParse(colorString.Trim(), out Color color))
                        return false;
                }
            }

            if (availableDesignsResourceParameters.Techniques != null)
            {
                foreach (var techniqueString in availableDesignsResourceParameters.Techniques)
                {
                    if (!Enum.TryParse(techniqueString.Trim(), out Technique style))
                        return false;
                }
            }

            if (availableDesignsResourceParameters.Genders != null)
            {
                foreach (var genderString in availableDesignsResourceParameters.Genders)
                {
                    if (!Enum.TryParse(genderString.Trim(), out Gender gender))
                        return false;
                }
            }

            return true;
        }
    }
}

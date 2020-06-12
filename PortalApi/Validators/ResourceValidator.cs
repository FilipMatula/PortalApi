using PortalApi.ProfilesProperties;
using PortalApi.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Validators
{
    //TODO: Dodac walidacje miast
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
                    if (!Enum.TryParse(styleString.Trim(), out TattooStyle style))
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

        public bool ValidDesignsParameters(AvailableDesignsResourceParameters availableDesignsResourceParameters)
        {
            if (availableDesignsResourceParameters.PageSize <= 0)
                return false;

            if (availableDesignsResourceParameters.PageNumber <= 0)
                return false;

            if (availableDesignsResourceParameters.Styles != null)
            {
                foreach (var styleString in availableDesignsResourceParameters.Styles)
                {
                    if (!Enum.TryParse(styleString.Trim(), out TattooStyle style))
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

            if (availableDesignsResourceParameters.PriceFrom != null)
            {
                if (availableDesignsResourceParameters.PriceFrom < 0)
                    return false;
            }

            if (availableDesignsResourceParameters.PriceTo != null)
            {
                if (availableDesignsResourceParameters.PriceTo < 0)
                    return false;
            }

            if (availableDesignsResourceParameters.PriceFrom != null && availableDesignsResourceParameters.PriceTo != null)
            {
                if (availableDesignsResourceParameters.PriceTo < availableDesignsResourceParameters.PriceFrom)
                    return false;
            }

            if (!string.IsNullOrWhiteSpace(availableDesignsResourceParameters.OrderBy))
            {
                var trimmedField = availableDesignsResourceParameters.OrderBy.Trim();
                List<string> availableOptions = new List<string>() { "datedesc" , "date", "pricedesc", "price" };

                if (!availableOptions.Contains(trimmedField))
                    return false;
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool ValidModelsPhotosParameters(ModelsPhotosResourceParameters modelsPhotosResourceParameters)
        {
            if (modelsPhotosResourceParameters.PageSize <= 0)
                return false;

            if (modelsPhotosResourceParameters.PageNumber <= 0)
                return false;

            if (modelsPhotosResourceParameters.Genders != null)
            {
                foreach (var genderString in modelsPhotosResourceParameters.Genders)
                {
                    if (!Enum.TryParse(genderString.Trim(), out Gender gender))
                        return false;
                }
            }

            if (modelsPhotosResourceParameters.Styles != null)
            {
                foreach (var styleString in modelsPhotosResourceParameters.Styles)
                {
                    if (!Enum.TryParse(styleString.Trim(), out ModelingStyle modelingStyle))
                        return false;
                }
            }

            if (modelsPhotosResourceParameters.Experiences != null)
            {
                foreach (var experienceString in modelsPhotosResourceParameters.Experiences)
                {
                    if (!Enum.TryParse(experienceString.Trim(), out Experience experience))
                        return false;
                }
            }

            if (modelsPhotosResourceParameters.AgeFrom != null)
            {
                if (modelsPhotosResourceParameters.AgeFrom < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.AgeTo != null)
            {
                if (modelsPhotosResourceParameters.AgeTo < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.AgeFrom != null && modelsPhotosResourceParameters.AgeTo != null)
            {
                if (modelsPhotosResourceParameters.AgeTo < modelsPhotosResourceParameters.AgeFrom)
                    return false;
            }

            return true;
        }

        public bool ValidPhotographersPhotosParameters(PhotographersPhotosResourceParameters photographersPhotosResourceParameters)
        {
            if (photographersPhotosResourceParameters.PageSize <= 0)
                return false;

            if (photographersPhotosResourceParameters.PageNumber <= 0)
                return false;

            if (photographersPhotosResourceParameters.Experiences != null)
            {
                foreach (var experienceString in photographersPhotosResourceParameters.Experiences)
                {
                    if (!Enum.TryParse(experienceString.Trim(), out Experience experience))
                        return false;
                }
            }

            if (photographersPhotosResourceParameters.Styles != null)
            {
                foreach (var styleString in photographersPhotosResourceParameters.Styles)
                {
                    if (!Enum.TryParse(styleString.Trim(), out ModelingStyle modelingStyle))
                        return false;
                }
            }

            return true;
        }
    }
}

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

            if (tattoosResourceParameters.TattooStyles != null)
            {
                foreach (var styleString in tattoosResourceParameters.TattooStyles)
                {
                    if (!Enum.TryParse(styleString.Trim(), out TattooStyle tattooStyle))
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
                    if (!Enum.TryParse(techniqueString.Trim(), out Technique technique))
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

            if (availableDesignsResourceParameters.TattooStyles != null)
            {
                foreach (var styleString in availableDesignsResourceParameters.TattooStyles)
                {
                    if (!Enum.TryParse(styleString.Trim(), out TattooStyle tattooStyle))
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
                    if (!Enum.TryParse(techniqueString.Trim(), out Technique technique))
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

            if (modelsPhotosResourceParameters.ModelingStyles != null)
            {
                foreach (var styleString in modelsPhotosResourceParameters.ModelingStyles)
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

            if (modelsPhotosResourceParameters.HeightFrom != null)
            {
                if (modelsPhotosResourceParameters.HeightFrom < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.HeightTo != null)
            {
                if (modelsPhotosResourceParameters.HeightTo < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.HeightFrom != null && modelsPhotosResourceParameters.HeightTo != null)
            {
                if (modelsPhotosResourceParameters.HeightTo < modelsPhotosResourceParameters.HeightFrom)
                    return false;
            }

            if (modelsPhotosResourceParameters.WeightFrom != null)
            {
                if (modelsPhotosResourceParameters.WeightFrom < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.WeightTo != null)
            {
                if (modelsPhotosResourceParameters.WeightTo < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.WeightFrom != null && modelsPhotosResourceParameters.WeightTo != null)
            {
                if (modelsPhotosResourceParameters.WeightTo < modelsPhotosResourceParameters.WeightFrom)
                    return false;
            }

            if (modelsPhotosResourceParameters.BreastFrom != null)
            {
                if (modelsPhotosResourceParameters.BreastFrom < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.BreastTo != null)
            {
                if (modelsPhotosResourceParameters.BreastTo < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.BreastFrom != null && modelsPhotosResourceParameters.BreastTo != null)
            {
                if (modelsPhotosResourceParameters.BreastTo < modelsPhotosResourceParameters.BreastFrom)
                    return false;
            }

            if (modelsPhotosResourceParameters.WaistFrom != null)
            {
                if (modelsPhotosResourceParameters.WaistFrom < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.WaistTo != null)
            {
                if (modelsPhotosResourceParameters.WaistTo < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.WaistFrom != null && modelsPhotosResourceParameters.WaistTo != null)
            {
                if (modelsPhotosResourceParameters.WaistTo < modelsPhotosResourceParameters.WaistFrom)
                    return false;
            }

            if (modelsPhotosResourceParameters.HipFrom != null)
            {
                if (modelsPhotosResourceParameters.HipFrom < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.HipTo != null)
            {
                if (modelsPhotosResourceParameters.HipTo < 0)
                    return false;
            }

            if (modelsPhotosResourceParameters.HipFrom != null && modelsPhotosResourceParameters.HipTo != null)
            {
                if (modelsPhotosResourceParameters.HipTo < modelsPhotosResourceParameters.HipFrom)
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

            if (photographersPhotosResourceParameters.ModelingStyles != null)
            {
                foreach (var styleString in photographersPhotosResourceParameters.ModelingStyles)
                {
                    if (!Enum.TryParse(styleString.Trim(), out ModelingStyle modelingStyle))
                        return false;
                }
            }

            return true;
        }
    }
}

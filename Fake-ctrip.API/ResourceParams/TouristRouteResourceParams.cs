﻿using System.Text.RegularExpressions;

namespace Fake_ctrip.API.ResourceParams
{
    public class TouristRouteResourceParams
    {
        public string? Keyword { get; set; }
        private string? _rating;
        public string? Rating
        {
            get { return _rating; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Regex regex = new Regex(@"([A-Za-z0-9\-]+)(\d+)");
                    Match match = regex.Match(value);
                    if (match.Success)
                    {
                        RatingOperator = match.Groups[1].Value;
                        RatingVal = int.Parse(match.Groups[2].Value);
                    }
                }
            }
        }
        public string? RatingOperator { get; set; }
        public int? RatingVal { get; set; }
    }
}

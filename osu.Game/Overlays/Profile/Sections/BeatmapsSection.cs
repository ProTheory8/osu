﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Online.API.Requests;
using osu.Game.Overlays.Profile.Sections.Beatmaps;

namespace osu.Game.Overlays.Profile.Sections
{
    public class BeatmapsSection : ProfileSection
    {
        public override string Title => "Beatmaps";

        public override string Identifier => "beatmaps";

        public BeatmapsSection()
        {
            Children = new[]
            {
                new PaginatedBeatmapContainer(BeatmapSetType.Favourite, User, "Favourite Beatmaps", "None... yet."),
                new PaginatedBeatmapContainer(BeatmapSetType.Ranked_And_Approved, User, "Ranked & Approved Beatmaps", "None... yet."),
            };
        }
    }
}

﻿using LANCommander.SDK.Enums;
using System;
using System.Collections.Generic;

namespace LANCommander.SDK.Models
{
    public class Game : BaseModel
    {
        public string Title { get; set; }
        public string SortTitle { get; set; }
        public string DirectoryName { get; set; }
        public string Description { get; set; }
        public DateTime ReleasedOn { get; set; }
        public string InstallDirectory { get; set; }
        public GameType Type { get; set; }
        public Game BaseGame { get; set; }
        public virtual IEnumerable<Action> Actions { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
        public virtual IEnumerable<Company> Publishers { get; set; }
        public virtual IEnumerable<Company> Developers { get; set; }
        public virtual IEnumerable<Archive> Archives { get; set; }
        public virtual IEnumerable<Script> Scripts { get; set; }
        public virtual IEnumerable<Media> Media { get; set; }
        public virtual IEnumerable<Redistributable> Redistributables { get; set; }
        public virtual IEnumerable<Server> Servers { get; set; }
    }
}

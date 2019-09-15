﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using puck.core.Abstract;
using System.ComponentModel.DataAnnotations;
using puck.core.Attributes;

namespace puck.core.Models.EditorSettings
{
    public enum PuckPickerSelectionType { node, variant, both };
    [FriendlyClassName(Name="Puck Picker Editor Settings")]
    [Display(Name = "Puck Picker Editor Settings")]
    public class PuckPickerEditorSettings:Attribute,I_Puck_Editor_Settings
    {
        [UIHint("PuckHidden")]
        public string StartPathId { get; set; }
        public int MaxPick { get; set; }
        [UIHint("PuckPickerSelectionType")]
        public string SelectionType { get; set; }
        public bool AllowUnpublished { get; set; }
        public bool AllowDuplicates { get; set; }

        [UIHint("PuckPicker")]
        public List<PuckPicker> StartPath { get; set; }
        
    }
}

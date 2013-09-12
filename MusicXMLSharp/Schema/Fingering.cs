using MusicXMLSharp.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Fingering {
    
    private YesNo substitutionField;
    
    private bool substitutionFieldSpecified;
    
    private YesNo alternateField;
    
    private bool alternateFieldSpecified;
    
    private AboveBelow placementField;
    
    private bool placementFieldSpecified;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNo substitution {
        get {
            return this.substitutionField;
        }
        set {
            this.substitutionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool substitutionSpecified {
        get {
            return this.substitutionFieldSpecified;
        }
        set {
            this.substitutionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNo alternate {
        get {
            return this.alternateField;
        }
        set {
            this.alternateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool alternateSpecified {
        get {
            return this.alternateFieldSpecified;
        }
        set {
            this.alternateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AboveBelow placement {
        get {
            return this.placementField;
        }
        set {
            this.placementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool placementSpecified {
        get {
            return this.placementFieldSpecified;
        }
        set {
            this.placementFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Fret {
    
    private string fontfamilyField;
    
    private FontStyle _fontStyleField;
    
    private bool fontstyleFieldSpecified;
    
    private string fontsizeField;
    
    private FontWeight _fontWeightField;
    
    private bool fontweightFieldSpecified;
    
    private string colorField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType="token")]
    public string fontfamily {
        get {
            return this.fontfamilyField;
        }
        set {
            this.fontfamilyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
    public FontStyle FontStyle {
        get {
            return this._fontStyleField;
        }
        set {
            this._fontStyleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool fontstyleSpecified {
        get {
            return this.fontstyleFieldSpecified;
        }
        set {
            this.fontstyleFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
    public string fontsize {
        get {
            return this.fontsizeField;
        }
        set {
            this.fontsizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
    public FontWeight FontWeight {
        get {
            return this._fontWeightField;
        }
        set {
            this._fontWeightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool fontweightSpecified {
        get {
            return this.fontweightFieldSpecified;
        }
        set {
            this.fontweightFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string color {
        get {
            return this.colorField;
        }
        set {
            this.colorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="nonNegativeInteger")]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="measure-style")]
public partial class MeasureStyle {
    
    private object itemField;
    
    private string numberField;
    
    private string fontfamilyField;
    
    private FontStyle _fontStyleField;
    
    private bool fontstyleFieldSpecified;
    
    private string fontsizeField;
    
    private FontWeight _fontWeightField;
    
    private bool fontweightFieldSpecified;
    
    private string colorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("beat-repeat", typeof(BeatRepeat))]
    [System.Xml.Serialization.XmlElementAttribute("measure-repeat", typeof(MeasureRepeat))]
    [System.Xml.Serialization.XmlElementAttribute("multiple-rest", typeof(MultipleRest))]
    [System.Xml.Serialization.XmlElementAttribute("slash", typeof(Slash))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public string number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
    
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
}
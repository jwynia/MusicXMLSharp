/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Print {
    
    private pagelayout pagelayoutField;
    
    private systemlayout systemlayoutField;
    
    private stafflayout[] stafflayoutField;
    
    private MeasureLayout _measureLayoutField;
    
    private MeasureNumbering _measureNumberingField;
    
    private namedisplay partnamedisplayField;
    
    private namedisplay partabbreviationdisplayField;
    
    private decimal staffspacingField;
    
    private bool staffspacingFieldSpecified;
    
    private YesNo newsystemField;
    
    private bool newsystemFieldSpecified;
    
    private YesNo newpageField;
    
    private bool newpageFieldSpecified;
    
    private string blankpageField;
    
    private string pagenumberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("page-layout")]
    public pagelayout pagelayout {
        get {
            return this.pagelayoutField;
        }
        set {
            this.pagelayoutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("system-layout")]
    public systemlayout systemlayout {
        get {
            return this.systemlayoutField;
        }
        set {
            this.systemlayoutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("staff-layout")]
    public stafflayout[] stafflayout {
        get {
            return this.stafflayoutField;
        }
        set {
            this.stafflayoutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("measure-layout")]
    public MeasureLayout MeasureLayout {
        get {
            return this._measureLayoutField;
        }
        set {
            this._measureLayoutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("measure-numbering")]
    public MeasureNumbering MeasureNumbering {
        get {
            return this._measureNumberingField;
        }
        set {
            this._measureNumberingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("part-name-display")]
    public namedisplay partnamedisplay {
        get {
            return this.partnamedisplayField;
        }
        set {
            this.partnamedisplayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("part-abbreviation-display")]
    public namedisplay partabbreviationdisplay {
        get {
            return this.partabbreviationdisplayField;
        }
        set {
            this.partabbreviationdisplayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("staff-spacing")]
    public decimal staffspacing {
        get {
            return this.staffspacingField;
        }
        set {
            this.staffspacingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool staffspacingSpecified {
        get {
            return this.staffspacingFieldSpecified;
        }
        set {
            this.staffspacingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("new-system")]
    public YesNo newsystem {
        get {
            return this.newsystemField;
        }
        set {
            this.newsystemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool newsystemSpecified {
        get {
            return this.newsystemFieldSpecified;
        }
        set {
            this.newsystemFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("new-page")]
    public YesNo newpage {
        get {
            return this.newpageField;
        }
        set {
            this.newpageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool newpageSpecified {
        get {
            return this.newpageFieldSpecified;
        }
        set {
            this.newpageFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("blank-page", DataType="positiveInteger")]
    public string blankpage {
        get {
            return this.blankpageField;
        }
        set {
            this.blankpageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("page-number", DataType="token")]
    public string pagenumber {
        get {
            return this.pagenumberField;
        }
        set {
            this.pagenumberField = value;
        }
    }
}
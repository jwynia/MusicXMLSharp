/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="figured-bass")]
public partial class FiguredBass {
    
    private Figure[] figureField;
    
    private decimal durationField;
    
    private FormattedText footnoteField;
    
    private Level levelField;
    
    private YesNo printdotField;
    
    private bool printdotFieldSpecified;
    
    private YesNo printlyricField;
    
    private bool printlyricFieldSpecified;
    
    private YesNo parenthesesField;
    
    private bool parenthesesFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Figure")]
    public Figure[] figure {
        get {
            return this.figureField;
        }
        set {
            this.figureField = value;
        }
    }
    
    /// <remarks/>
    public decimal duration {
        get {
            return this.durationField;
        }
        set {
            this.durationField = value;
        }
    }
    
    /// <remarks/>
    public FormattedText footnote {
        get {
            return this.footnoteField;
        }
        set {
            this.footnoteField = value;
        }
    }
    
    /// <remarks/>
    public Level level {
        get {
            return this.levelField;
        }
        set {
            this.levelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-dot")]
    public YesNo printdot {
        get {
            return this.printdotField;
        }
        set {
            this.printdotField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printdotSpecified {
        get {
            return this.printdotFieldSpecified;
        }
        set {
            this.printdotFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-lyric")]
    public YesNo printlyric {
        get {
            return this.printlyricField;
        }
        set {
            this.printlyricField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printlyricSpecified {
        get {
            return this.printlyricFieldSpecified;
        }
        set {
            this.printlyricFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNo parentheses {
        get {
            return this.parenthesesField;
        }
        set {
            this.parenthesesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool parenthesesSpecified {
        get {
            return this.parenthesesFieldSpecified;
        }
        set {
            this.parenthesesFieldSpecified = value;
        }
    }
}
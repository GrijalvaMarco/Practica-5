
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Button botonRestar;
	private global::Gtk.Button botonSumar;
	private global::Gtk.Button botonMultiplicar;
	private global::Gtk.Button botonDividir;
	private global::Gtk.Label labelResultado;
	private global::Gtk.Entry entryResultado;
	private global::Gtk.Entry entryNumero2;
	private global::Gtk.Label labelNumero2;
	private global::Gtk.Label labelTitulo;
	private global::Gtk.Entry entryNumero1;
	private global::Gtk.Label labelNumero1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.botonRestar = new global::Gtk.Button ();
		this.botonRestar.CanFocus = true;
		this.botonRestar.Name = "botonRestar";
		this.botonRestar.UseUnderline = true;
		this.botonRestar.Label = global::Mono.Unix.Catalog.GetString ("Restar");
		this.fixed1.Add (this.botonRestar);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.botonRestar]));
		w1.X = 192;
		w1.Y = 319;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.botonSumar = new global::Gtk.Button ();
		this.botonSumar.CanFocus = true;
		this.botonSumar.Name = "botonSumar";
		this.botonSumar.UseUnderline = true;
		this.botonSumar.Label = global::Mono.Unix.Catalog.GetString ("Sumar");
		this.fixed1.Add (this.botonSumar);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.botonSumar]));
		w2.X = 110;
		w2.Y = 320;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.botonMultiplicar = new global::Gtk.Button ();
		this.botonMultiplicar.CanFocus = true;
		this.botonMultiplicar.Name = "botonMultiplicar";
		this.botonMultiplicar.UseUnderline = true;
		this.botonMultiplicar.Label = global::Mono.Unix.Catalog.GetString ("Multiplicar");
		this.fixed1.Add (this.botonMultiplicar);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.botonMultiplicar]));
		w3.X = 268;
		w3.Y = 321;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.botonDividir = new global::Gtk.Button ();
		this.botonDividir.CanFocus = true;
		this.botonDividir.Name = "botonDividir";
		this.botonDividir.UseUnderline = true;
		this.botonDividir.Label = global::Mono.Unix.Catalog.GetString ("Dividir");
		this.fixed1.Add (this.botonDividir);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.botonDividir]));
		w4.X = 367;
		w4.Y = 322;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelResultado = new global::Gtk.Label ();
		this.labelResultado.Name = "labelResultado";
		this.labelResultado.LabelProp = global::Mono.Unix.Catalog.GetString ("Resultado");
		this.fixed1.Add (this.labelResultado);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.labelResultado]));
		w5.X = 131;
		w5.Y = 254;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entryResultado = new global::Gtk.Entry ();
		this.entryResultado.CanFocus = true;
		this.entryResultado.Name = "entryResultado";
		this.entryResultado.IsEditable = true;
		this.entryResultado.InvisibleChar = '•';
		this.fixed1.Add (this.entryResultado);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entryResultado]));
		w6.X = 243;
		w6.Y = 251;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entryNumero2 = new global::Gtk.Entry ();
		this.entryNumero2.CanFocus = true;
		this.entryNumero2.Name = "entryNumero2";
		this.entryNumero2.IsEditable = true;
		this.entryNumero2.InvisibleChar = '•';
		this.fixed1.Add (this.entryNumero2);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entryNumero2]));
		w7.X = 242;
		w7.Y = 168;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelNumero2 = new global::Gtk.Label ();
		this.labelNumero2.Name = "labelNumero2";
		this.labelNumero2.LabelProp = global::Mono.Unix.Catalog.GetString ("Número 2");
		this.fixed1.Add (this.labelNumero2);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.labelNumero2]));
		w8.X = 131;
		w8.Y = 169;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelTitulo = new global::Gtk.Label ();
		this.labelTitulo.Name = "labelTitulo";
		this.labelTitulo.LabelProp = global::Mono.Unix.Catalog.GetString ("Aplicación gtk Calcular operaciones sencillas.");
		this.fixed1.Add (this.labelTitulo);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.labelTitulo]));
		w9.X = 126;
		w9.Y = 17;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entryNumero1 = new global::Gtk.Entry ();
		this.entryNumero1.CanFocus = true;
		this.entryNumero1.Name = "entryNumero1";
		this.entryNumero1.IsEditable = true;
		this.entryNumero1.InvisibleChar = '•';
		this.fixed1.Add (this.entryNumero1);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entryNumero1]));
		w10.X = 244;
		w10.Y = 88;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelNumero1 = new global::Gtk.Label ();
		this.labelNumero1.Name = "labelNumero1";
		this.labelNumero1.LabelProp = global::Mono.Unix.Catalog.GetString ("Número 1");
		this.fixed1.Add (this.labelNumero1);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.labelNumero1]));
		w11.X = 130;
		w11.Y = 91;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 625;
		this.DefaultHeight = 427;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.botonRestar.Clicked += new global::System.EventHandler (this.OnBotonRestarClicked);
		this.botonSumar.Clicked += new global::System.EventHandler (this.OnBotonSumarClicked);
		this.botonMultiplicar.Clicked += new global::System.EventHandler (this.OnBotonMultiplicarClicked);
		this.botonDividir.Clicked += new global::System.EventHandler (this.OnBotonDividirClicked);
	}
}

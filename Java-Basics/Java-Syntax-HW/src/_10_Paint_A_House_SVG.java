import java.awt.Rectangle;
import java.awt.Graphics2D;
import java.awt.Color;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

import org.w3c.dom.Document;
import org.apache.batik.svggen.SVGGraphics2D;
import org.apache.batik.dom.GenericDOMImplementation;
import org.w3c.dom.DOMImplementation;

public class _10_Paint_A_House_SVG {

  public void paint(Graphics2D g2d) {
    g2d.setPaint(Color.LIGHT_GRAY);    
    g2d.fill(new Rectangle(100, 100, 50, 50));
    g2d.fill(new Rectangle(220, 208, 2, 5));
    g2d.setPaint(Color.BLACK);
    g2d.drawLine(112, 108, 122, 108);    
  }

  public static void main(String[] args) throws IOException {

    // Get a DOMImplementation.
    DOMImplementation domImpl = GenericDOMImplementation.getDOMImplementation();

    // Create an instance of org.w3c.dom.Document.
    String svgNS = "http://www.w3.org/2000/svg";
    Document document = domImpl.createDocument(svgNS, "svg", null);

    // Create an instance of the SVG Generator.
    SVGGraphics2D svgGenerator = new SVGGraphics2D(document);

    // Ask the test to render into the SVG Graphics2D implementation.
    _10_Paint_A_House_SVG test = new _10_Paint_A_House_SVG();
    test.paint(svgGenerator);

    try {
		File file = new File(System.getProperty("user.home")+"/Desktop/index.html");

		// if file doesnt exists, then create it
		if (!file.exists()) {
			file.createNewFile();
		}
		
		FileWriter fw = new FileWriter(file.getAbsoluteFile());
		BufferedWriter bw = new BufferedWriter(fw);
		// Finally, stream out SVG to the standard output using
	    // UTF-8 encoding.
	    boolean useCSS = true; // we want to use CSS style attributes	    
	    svgGenerator.stream(bw, useCSS);
		
	    //bw.write(content);
		bw.close();

		System.out.println("Done");

	} catch (IOException e) {
		e.printStackTrace();
	}
    
    System.out.println("DONE");
  }
}
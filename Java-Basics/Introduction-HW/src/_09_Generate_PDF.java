import java.io.FileOutputStream;
import java.util.Date;

import com.itextpdf.text.Anchor;
import com.itextpdf.text.BadElementException;
import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Chapter;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Element;
import com.itextpdf.text.Font;
import com.itextpdf.text.FontFactory;
import com.itextpdf.text.List;
import com.itextpdf.text.ListItem;
import com.itextpdf.text.PageSize;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Phrase;
import com.itextpdf.text.Section;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;


public class _09_Generate_PDF{
  private static String FILE = System.getProperty("user.home") + "/Desktop/GeneratePDF1.pdf";
  private static Font catFont = new Font(Font.FontFamily.TIMES_ROMAN, 18, Font.BOLD);
  private static Font redFont = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL, BaseColor.RED);
  private static Font subFont = new Font(Font.FontFamily.TIMES_ROMAN, 16, Font.BOLD);
  private static Font smallBold = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD);

  public static void main(String[] args) {
    try {
      Document document = new Document();
      PdfWriter.getInstance(document, new FileOutputStream(FILE));
      document.open();
      
      for (int i = 0; i < 13; i++) {
    	  for (int j = 0; j < 4; j++) {
    		  generateCard(document);
    		  System.out.println("Generate !!");
    	  }
    	  
      }
      
      addMetaData(document);
      document.close();
      System.out.println("Ok");
    } catch (Exception e) {
      e.printStackTrace();
    }
  }

	private static void generateCard(Document document) throws DocumentException {
		PdfPTable table;
		PdfPCell cell;
		
		// single element w/ border
		table = new PdfPTable(1);
		cell = new PdfPCell(new Phrase("A", FontFactory.getFont(FontFactory.HELVETICA_BOLD, 11, Font.BOLD)));
		cell.setBorderWidth(1);
		//cell.setPadding(5);
		//cell.setPaddingTop(3);
		cell.setHorizontalAlignment(Element.ALIGN_CENTER);
		cell.setFixedHeight(50f);
		
		table.addCell(cell);
		table.setWidthPercentage(new float[] { 45f }, PageSize.LETTER);
		table.setHorizontalAlignment(Element.ALIGN_CENTER);
		document.add(table);
	}

  // iText allows to add metadata to the PDF which can be viewed in your Adobe
  // Reader
  // under File -> Properties
  private static void addMetaData(Document document) {
    document.addTitle("Cards & Suits");
    document.addSubject("Task 09 Java Basics Homework");
    document.addKeywords("Java, PDF, iText");
    document.addAuthor("Nikolay Bankin");
    document.addCreator("Bankin");
  }
  
  private static void addEmptyLine(Paragraph paragraph, int number) {
    for (int i = 0; i < number; i++) {
      paragraph.add(new Paragraph(" "));
    }
  }
} 
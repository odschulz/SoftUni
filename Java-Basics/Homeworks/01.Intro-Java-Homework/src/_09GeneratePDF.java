import com.itextpdf.text.*;
import com.itextpdf.text.pdf.*;

import java.io.FileOutputStream;

public class _09GeneratePDF {
	public static void main(String[] args) {
		Document document = new Document();
		//document.setPageSize(PageSize.A4);
		try {
			PdfWriter.getInstance(document, new FileOutputStream("DeckOfCards.pdf"));
			document.open();
			PdfPTable table = new PdfPTable(4);
            table.getDefaultCell().setFixedHeight(100);
            table.setWidthPercentage(60);
            table.getDefaultCell().setHorizontalAlignment(Element.ALIGN_CENTER);
            table.getDefaultCell().setVerticalAlignment(Element.ALIGN_MIDDLE);
            BaseFont base = BaseFont.createFont("FreeSerif.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
			Font[] fonts = {
					new Font(base, 20f, Font.BOLD, BaseColor.BLACK),
					new Font(base, 20f, Font.BOLD, BaseColor.RED)
			};
			char[] suit = {
					'\u2663', '\u2666', '\u2665', '\u2660'
			};

			for (int i = 2; i <= 14; i++) {
				String card = "";
                switch (i) {
                case 11: card += "J"; break;
                case 12: card += "Q"; break;
                case 13: card += "K"; break;
                case 14: card += "A"; break;
                default: card +=  i; break;
                }	
                for (int j = 1; j <= 4; j++) {
                        switch (j) {
                        case 1: table.addCell(new Paragraph(card + suit[0], fonts[0])); break; 
                        case 2: table.addCell(new Paragraph(card + suit[1], fonts[1])); break; 
                        case 3: table.addCell(new Paragraph(card + suit[2], fonts[1])); break;
                        case 4: table.addCell(new Paragraph(card + suit[3], fonts[0])); break;
                        }
                }
			}
			document.add(table);
	        document.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

}

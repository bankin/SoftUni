package _02;

import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class OfficeStuff {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		HashMap<String,LinkedHashMap<String, Integer>> info = new HashMap<String, LinkedHashMap<String, Integer>>();
		int linesCount = Integer.parseInt(scan.nextLine());
		
		for (int i = 0; i < linesCount; i++) {
			String line = scan.nextLine();
			line = line.replace("|", "");
			line = line.replace(" ", "");
			String[] company = line.split("-");
			
			HashMap<String, Integer> value = info.get(company[0]);
			if (value != null) {
			    if(value.containsKey(company[2])){			    	
			    	value.put(company[2], value.get(company[2]) + Integer.parseInt(company[1]));
			    }
			    else{
			    	value.put(company[2], Integer.parseInt(company[1]));
			    }
			} else {
			    info.put(company[0], new LinkedHashMap<String, Integer>());
			    info.get(company[0]).put(company[2], Integer.parseInt(company[1]));
			}
		}
		
		TreeMap sorted = new TreeMap(info);
		
		Iterator<String> keySetIterator = sorted.keySet().iterator();
		
		Boolean first = true;
		while(keySetIterator.hasNext()){
		  String key = keySetIterator.next();
		  HashMap<String, Integer> products = info.get(key);
		  System.out.print(key+": ");
		  Iterator<String> keyProducts = products.keySet().iterator();
		  while(keyProducts.hasNext()){
			  String product = keyProducts.next();
			  if(first){
				  System.out.print(product+"-"+products.get(product));
				  first = false;
			  }
			  else{
				  System.out.print(", "+product+"-"+products.get(product));
			  }
			  
		  }
		  System.out.println();
		  first = true;
		}
	}
}

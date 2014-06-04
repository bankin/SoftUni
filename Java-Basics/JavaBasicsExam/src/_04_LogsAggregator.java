import java.util.HashMap;
import java.util.Iterator;
import java.util.Scanner;
import java.util.TreeMap;	

/*
 * 
11
192.168.0.11 peter 33
10.10.17.33 alex 12
10.10.17.35 peter 30
10.10.17.34 peter 120
10.10.17.34 peter 120
212.50.118.81 alex 46
212.50.118.81 alex 4
10.9.9.9 peter 0
12.2.2.3 bankin 12
0.99.3.33 nik 10
10.9.8.9 peter 0
 * 
 */

public class _04_LogsAggregator {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		HashMap<String, String> ip = new HashMap<String, String>();
		HashMap<String, Long> duration = new HashMap<String, Long>();
		int lines = Integer.parseInt(scan.nextLine());
		
		for (int i = 0; i < lines; i++) {
			String row = scan.nextLine();
			String[] data = row.split(" ");
			data[0] = data[0].replaceAll("\\s+","");
			data[1] = data[1].replaceAll("\\s+","");
			data[2] = data[2].replaceAll("\\s+","");
//			if(data.length > 3){
//				for (int j = 0; j < data.length; j++) {
//					if(data[j] == ""){
//						for (int j2 = j; j2 < data.length - 1; j2++) {
//							data[j2] = data[j2+1];
//						}
//					}
//				}
//			}
			//System.out.println("DATA "+printData(data));
			String currentIP = data[0];
			if(ip.containsKey(data[1])){
				currentIP = ip.get(data[1]);
				if(!currentIP.contains(data[0])){
					currentIP += ", "+data[0];
				}
				ip.remove(data[1]);
			}
			ip.put(data[1], currentIP);
			
			long currentDur = Long.parseLong(data[2]);
			if(duration.containsKey(data[1])){
				currentDur += duration.get(data[1]);
				duration.remove(data[1]);
			}
			duration.put(data[1], currentDur);	
		}
		
		TreeMap<String, String> sortedIP = new TreeMap<String, String>(ip);
		TreeMap<String, Long> sordetDur = new TreeMap<String, Long>(duration); 
		//System.out.println(sortedHashMap);
		
		Iterator<String> keySetIterator = sortedIP.keySet().iterator();

		while(keySetIterator.hasNext()){
		  String key = keySetIterator.next();
		  System.out.println(key + ": " + sordetDur.get(key) + " [" + sortIpAddresses(ip.get(key)) + "]");
		}

	}

	private static String sortIpAddresses(String string) {
		string = string.replaceAll("\\s+","");
		String[] ips = string.split(",");
		
		int j;
		boolean flag = true;  // will determine when the sort is finished
		String temp;

		while ( flag ){
			flag = false;
			for (j = 0;  j < ips.length - 1;  j++){
				if (ips[j].compareToIgnoreCase(ips[j+1]) > 0){
					temp = ips[j];
					ips[j] = ips[ j+1];     // swapping
					ips[j+1] = temp;
					flag = true;
				}
			}
		}

		
		String toReturn = ""; 
		for (int i = 0; i < ips.length; i++) {
			if(i != 0){
				toReturn += ", "+ips[i];
			}
			else{
				toReturn = ips[i];			
			}
		}
		
		return toReturn;
	}
}

// import java.util.ArrayList;
//import java.util.Arrays;
// import java.util.Scanner;

// class Test {

//         public static void main(String[] args) {

//                 Scanner sc = new Scanner(System.in);
//                 int dan = sc.nextInt();
//                 for (int i = 1; i <= 9; i++)
//                         if (i % 2 != 0) {
//                                 System.out.println(dan + "*" + i + "=" + dan * i);
//                         }

//         }
// }

// import java.util.Scanner;

// class Star {
//     public static void main(String[] args) {
//         Scanner scanner = new Scanner(System.in);
//         int n = scanner.nextInt();
//         for (int i = 1; i <= n; i++) {
//             for (int j = 1; j <= i; j++) {
//                 System.out.print("*");

//             }
//             System.out.println();

//         }

//     }
// }

// toString메서드

// class Box {
// 	private String conts;

// 	Box(String cont) {
// 		this.conts = cont;
// 	}

// 	public String toString() {
// 		return conts; // 문자열 반환
// 	}
// }

// public class Test {
// 	public static void main(String[] args) {
// 		StringBuilder stb = new StringBuilder("12");
// 		stb.append(34);
// 		System.out.println(stb.toString());
// 		System.out.println(stb);

// 		Box box = new Box("Camera");
// 		System.out.println(box.toString());
// 		System.out.println(box);
// 	}

// }

/*
 * 사용자로부터 몇단?
 * 3단
 * 
 * 3*1
 * 3*3
 * 3*5
 * 3*7
 * 3*9
 * 
 */

/*
 * 몇개의 별 출력할래?
 * 3
 *
 **
 ***
 * 4
 *
 **
 ***
 ****
 */

// ArrayList<Integer> arr = new ArrayList<>(Arrays.asList(10, 20, 30, 40, 50));
// System.out.println(arr);
// System.out.println(arr.get(4));
// System.out.println(arr.get(3));
// System.out.println(arr.get(2));
// System.out.println(arr.get(1));
// System.out.println(arr.get(0));

// for (int i = 0; i < 5 ; i++) {
// System.out.print(arr.get(i)+" ");

// }

// int arr[] = { 1, 2, 3, 4, 5 };

// for (int i = 0; i < 5; i++) {
// if (i % 2 != 0) {
// System.out.println(i);
// }
// }
// }

// }

public class Test {
    public static void main(String[] args) {
       int num = 1;

       while(true){
           if(((num % 8) == 0) && ((num % 16) == 0))
               break;
           num ++;
           System.out.println(num);
       }
    }
}
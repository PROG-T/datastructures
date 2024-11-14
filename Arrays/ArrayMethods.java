package Arrays;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class ArrayMethods {
    public static void main(String[] args) {
        List<Integer> list = new ArrayList<>();
        list.add(2);
        list.add(4);

        List<Integer> list2 = Arrays.asList(5,6, 7,8);
        System.out.println(list);
        System.out.println(list2);

        
    }
}

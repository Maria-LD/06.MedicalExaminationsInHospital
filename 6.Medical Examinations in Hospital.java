import java.util.Scanner;

public class MedicalExaminationsInHospital {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        try {
            //first input and checking if it's valid
            System.out.print("Enter the period you want to make calculations for: ");
            int period = Integer.parseInt(scanner.nextLine());
            while (period < 1 || period > 1000) {
                System.out.print("Invalid input! Period must be in range 1 - 1000 days: ");
                period = Integer.parseInt(scanner.nextLine());
            }

            int treatedPatients = 0;
            int untreatedPatients = 0;
            int numberOfDoctors = 7;

            for (int day = 1; day <= period; day++) {

                //second input and checking if it's valid
                System.out.printf("Enter number of patients for day %d: ", day);
                int currentPatients = Integer.parseInt(scanner.nextLine());
                while (currentPatients < 0 || currentPatients > 10000) {
                    System.out.print("Invalid input! Patients must be between 0 and 10000: ");
                    currentPatients = Integer.parseInt(scanner.nextLine());
                }

                if (day % 3 == 0 && (untreatedPatients > treatedPatients)) {
                    numberOfDoctors++;
                }

                if (currentPatients > numberOfDoctors) {
                    treatedPatients += numberOfDoctors;
                    untreatedPatients += currentPatients - numberOfDoctors;
                } else {
                    treatedPatients += currentPatients;
                }
            }

            System.out.printf("Treated patients: %d.\n", treatedPatients);
            System.out.printf("Untreated patients: %d.\n", untreatedPatients);

        }catch (Exception ex) {
            System.out.println("Invalid input! Start from the beginning!!!");
        }
    }
}

//#include<iostream>
//#include<fstream>
//#include<string>
//using namespace std;
//
//struct Student {
//	int id;
//	string name;
//	int age;
//	string course;
//};
//
//void insertdata();
//void display();
//void editdata(int id);
//void removedata(int id);
//
//int main() {
//	int choice, id;
//	while (true) {
//		cout << "\nStudent Record Management System" << endl;
//		cout << "1. Insert Student Record" << endl;
//		cout << "2. View All Student Records" << endl;
//		cout << "3. Delete Student Record by ID" << endl;
//		cout << "4. Update Student Record by ID" << endl;
//		cout << "5. Exit" << endl;
//		cout << "Enter your choice: ";
//		cin >> choice;
//
//		switch (choice) {
//		case 1:
//			insertdata();
//			break;
//		case 2:
//			display();
//			break;
//		case 3:
//			cout << "Enter Student ID to delete: ";
//			cin >> id;
//			removedata(id);
//			break;
//		case 4:
//			cout << "Enter Student ID to update: ";
//			cin >> id;
//			editdata(id);
//			break;
//		case 5:
//			cout << "Exiting the program..." << endl;
//			return 0;
//		default:
//			cout << "Invalid choice! Please try again." << endl;
//		}
//	}
//	system("pause");
//	return 0;
//}
//
//void insertdata() {
//	ofstream file("student.txt", ios::app);
//	if (!file) {
//		cout << "Error opening file!" << endl;
//		return;
//	}
//	Student s;
//	cout << "Enter the student id: ";
//	cin >> s.id;
//	cin.ignore();
//	cout << "Enter the student Name: ";
//	getline(cin, s.name);
//	cout << "Enter the student Age: ";
//	cin >> s.age;
//	cin.ignore();
//	cout << "Enter the student Course: ";
//	getline(cin, s.course);
//
//	file << s.id << "\n" << s.name << "\n" << s.age << "\n" << s.course << endl;
//	file.close();
//	cout << "Student record inserted successfully!" << endl;
//}
//
//void display() {
//	ifstream file("student.txt");
//	if (!file) {
//		cout << "Error opening file!" << endl;
//		return;
//	}
//	Student s;
//	cout << "Student Records" << endl;
//	while (file >> s.id) {
//		file.ignore();
//		getline(file, s.name);
//		file >> s.age;
//		file.ignore();
//		getline(file, s.course);
//
//		cout << "ID: " << s.id << ", Name: " << s.name << ", Age: " << s.age << ", Course: " << s.course << endl;
//	}
//	file.close();
//}
//
//void editdata(int id) {
//	ifstream file("student.txt");
//	ofstream tempFile("temp.txt");
//	if (!file || !tempFile) {
//		cout << "Error opening file!" << endl;
//		return;
//	}
//
//	Student s;
//	bool found = false;
//	while (file >> s.id) {
//		file.ignore();
//		getline(file, s.name);
//		file >> s.age;
//		file.ignore();
//		getline(file, s.course);
//
//		if (s.id == id) {
//			found = true;
//			cout << "Enter new Student Name: ";
//			cin.ignore();
//			getline(cin, s.name);
//			cout << "Enter new Student Age: ";
//			cin >> s.age;
//			cin.ignore();
//			cout << "Enter new Student Course: ";
//			getline(cin, s.course);
//		}
//		tempFile << s.id << "\n" << s.name << "\n" << s.age << "\n" << s.course << endl;
//	}
//
//	file.close();
//	tempFile.close();
//
//	remove("student.txt");
//	rename("temp.txt", "student.txt");
//
//	if (found) {
//		cout << "Student record updated successfully!" << endl;
//	}
//	else {
//		cout << "Student record not found!" << endl;
//	}
//}
//
//void removedata(int id) {
//	ifstream file("student.txt");
//	ofstream temp("temp.txt");
//	if (!file || !temp) {
//		cout << "Error opening file!" << endl;
//		return;
//	}
//
//	Student s;
//	bool found = false;
//	while (file >> s.id) {
//		file.ignore(); 
//		getline(file, s.name);
//		file >> s.age;
//		file.ignore();
//		getline(file, s.course);
//
//		if (s.id != id) {
//			temp << s.id << "\n" << s.name << "\n" << s.age << "\n" << s.course << endl;
//		}
//		else {
//			found = true;
//		}
//	}
//
//	file.close();
//	temp.close();
//
//	remove("student.txt");
//	rename("temp.txt", "student.txt");
//
//	if (found) {
//		cout << "Student record deleted successfully!" << endl;
//	}
//	else {
//		cout << "Student record not found!" << endl;
//	}
//}

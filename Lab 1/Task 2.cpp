#include<iostream>
#include<fstream>
#include<string>
using namespace std;

struct Product {
	int id;
	string name;
	double price;
	int quantity;
};

void insertproduct();
void display();
void editproduct(int id);
void removeproduct(int id);

int main() {
	int choice, id;
	while (true) {
		cout << "\nProduct Record Management System" << endl;
		cout << "1. Insert Product Record" << endl;
		cout << "2. View All Product Records" << endl;
		cout << "3. Delete Product Record by ID" << endl;
		cout << "4. Update Product Record by ID" << endl;
		cout << "5. Exit" << endl;
		cout << "Enter your choice: ";
		cin >> choice;

		switch (choice) {
		case 1:
			insertproduct();
			break;
		case 2:
			display();
			break;
		case 3:
			cout << "Enter Product ID to delete: ";
			cin >> id;
			removeproduct(id);
			break;
		case 4:
			cout << "Enter Product ID to update: ";
			cin >> id;
			editproduct(id);
			break;
		case 5:
			cout << "Exiting the program..." << endl;
			return 0;
		default:
			cout << "Invalid choice! Please try again." << endl;
		}
	}
	system("pause");
	return 0;
}

void insertproduct() {
	ofstream file("product.txt", ios::app);
	if (!file) {
		cout << "Error opening file!" << endl;
		return;
	}
	Product p;
	cout << "Enter the Product id: ";
	cin >> p.id;
	cin.ignore();
	cout << "Enter the Product Name: ";
	getline(cin, p.name);
	cout << "Enter the Product Price: ";
	cin >> p.price;
	cout << "Enter the Product Quantity: ";
	cin >> p.quantity;

	file << p.id << "\n" << p.name << "\n" << p.price << "\n" << p.quantity << endl;
	file.close();
	cout << "Product record inserted successfully!" << endl;
}

void display() {
	ifstream file("product.txt");
	if (!file) {
		cout << "Error opening file!" << endl;
		return;
	}
	Product p;
	cout << "Product Records" << endl;
	while (file >> p.id) {
		file.ignore();
		getline(file, p.name);
		file >> p.price;
		file >> p.quantity;
		file.ignore();

		cout << "ID: " << p.id << ", Name: " << p.name << ", Price: " << p.price << ", Quantity: " << p.quantity << endl;
	}
	file.close();
}

void editproduct(int id) {
	ifstream file("product.txt");
	ofstream temp("temp.txt");
	if (!file || !temp) {
		cout << "Error opening file!" << endl;
		return;
	}

	Product p;
	bool found = false;
	while (file >> p.id) {
		file.ignore();
		getline(file, p.name);
		file >> p.price;
		file >> p.quantity;
		file.ignore();

		if (p.id == id) {
			found = true;
			cout << "Enter new Product Name: ";
			cin.ignore();
			getline(cin, p.name);
			cout << "Enter new Product Price: ";
			cin >> p.price;
			cout << "Enter new Product Quantity: ";
			cin >> p.quantity;
		}

		temp << p.id << "\n" << p.name << "\n" << p.price << "\n" << p.quantity << endl;
	}

	file.close();
	temp.close();

	remove("product.txt");
	rename("temp.txt", "product.txt");

	if (found) {
		cout << "Product record updated successfully!" << endl;
	}
	else {
		cout << "Product record not found!" << endl;
	}
}

void removeproduct(int id) {
	ifstream file("product.txt");
	ofstream temp("temp.txt");
	if (!file || !temp) {
		cout << "Error opening file!" << endl;
		return;
	}

	Product p;
	bool found = false;
	while (file >> p.id) {
		file.ignore();
		getline(file, p.name);
		file >> p.price;
		file >> p.quantity;
		file.ignore();

		if (p.id != id) {
			temp << p.id << "\n" << p.name << "\n" << p.price << "\n" << p.quantity << endl;
		}
		else {
			found = true;
		}
	}

	file.close();
	temp.close();

	remove("product.txt");
	rename("temp.txt", "product.txt");

	if (found) {
		cout << "Product record deleted successfully!" << endl;
	}
	else {
		cout << "Product record not found!" << endl;
	}
}

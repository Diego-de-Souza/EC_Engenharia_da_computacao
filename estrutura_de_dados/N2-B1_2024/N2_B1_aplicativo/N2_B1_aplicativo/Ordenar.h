#pragma once
#include <string>
#include "Pessoa.h"
#include <vector>

class Bubble
{
private:
	int temp;

	void merge(std::vector<Pessoa>& arr, int l, int m, int r);

	int partition(std::vector<Pessoa>& arr, int low, int high);
public:
	void swap(std::string* xp, std::string* yp);

	void bubbleSort(int arr[], int n);

	void insertionSort(Pessoa arr[], int n);

	void selectionSort(Pessoa arr[], int n);

	void mergeSort(std::vector<Pessoa>& arr, int l, int r);

	void quickSort(std::vector<Pessoa>& arr, int low, int high);
};


bubble sort
	como funciona?
		É um método que verifica dois elementos para ver qual deles é maior, caso o segundo elementos seja maior que o primeiro ele não faz nada, já se for ao contrário ele troca a ordem dos elementos fazendo sempre o maior ficar depois, mas ele só faz essa verificação de 2 em dois da esquerda para direita, ou de cima para baixo.
		melhor caso O(n) - pior caso O(n²) - caso médio O(n²)


Insertion sort
	Como funciona?
		É um metodo que pega um valor, depois pega outroa valor e compara com o primeiro valor, se o segundo valor for menor que o primeiro ele passa o segundo valor para frente do primeiro valor, caso contrario fica depois do primeiro valor, pega outro valor e compara com o valor na posição anteriorna nova ordem, se for menor ele compara com o anterior a ele e assim sucessivamente até não ser menor que o anterior e é colocado na posição depois do menor que ele.
		melhor caso O(n) - pior caso O(n²) - caso médio O(n²)

Section sort 
	como funciona?
		é um método que guarda o primeiro valor e vare todos os outros valores para ver se tem um valor menor que o primeiro, se tiver quando terminar de verrer ele vai no valor menor e passa ele para antes do primeiro valor, pega o segundo valor reserva e novamente varre todos os elementos seguintes para verificar se tem um menor, se tiver coloca antes do guardado e assim por diante, ou seja, encontra o menor elemento em cada passo e o troca com o primeiro elemento não ordenado.
		melhor caso O(n²) - pior caso O(n²) - caso médio O(n²)

merge sort
	como funciona?
		Pega 2 valores e comparapara ver qual menor e ordenar, volta eles para o lugar e pega mais dois elementos e compara, volta eles para o lugar e ordena junto com os dois primeiro e volta os 4 para seu lugar ordenados, pega mais 2 elementos compara e volta para o lugar ordenado, pega mais dois e volta para o lugar ordenado, pega os 4 e volta para o lugar ordenado, depois pega os 8 e volta para o lugar ordenado e assim por diante.
		melhor caso O(n * log n) - pior caso O(n * log n) - caso médio O(n * log n)
quick sort
	como funciona?
		O método se baseia em dividir e conquistar, ele vai dividindo em parte menores a lista para reordenar até que tenha somente dois elementos em cada arranjo ordenado, em seguinda ele junta novamente os pedaçoes de forma ordenada.
		melhor caso O(n²) - pior caso O(n²) - caso médio O(n * log n)

heap sort
	Como funciona?
		Selecione o maior (ou menor) item do vetor e a seguir troque-o com o item que está na Heapsort a seguir troque-o com o item que está na última (ou primeira) posição do vetor; repita estas duas operações com os n - 1 itens restantes; depois com os n - 2 itens; e assim sucessivamente.
		melhor caso O(n * log n) - pior caso O(n * log n) - caso médio O(n * log n)

gnome sort
	Como funciona?
		O algoritmo percorre o vetor comparando seus elementos dois a dois, assim que ele encontra um elemento que está na posição incorreta, ou seja, um número maior antes de um menor, ele troca a posição dos elementos, e volta com este elemento até que encontre o seu respectivo lugar.
		melhor caso O(n) - pior caso O(n²) - caso médio O(n²)

bitonic sort
	Como funciona?
		 O seu princípio funcional baseia-se no compara-troca, onde dois elementos são comparados e se estiverem fora de ordem, serão trocados para obter a ordem classificada.
		malhor caso O(log² n)

recursão
	Como funciona?
		A idéia básica de um algoritmo recursivo consiste em diminuir sucessivamente o problema em um problema menor ou mais simples, até que o tamanho ou a simplicidade do problema reduzido permita resolvê-lo de forma direta, sem recorrer a si mesmo.
	

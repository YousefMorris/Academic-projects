#include<iostream>
#include<vector>
#include<unordered_map>
#include <map>
#include<string>
#include<stack>
using namespace std;
unordered_map<string, vector<pair<string, int>>> add_graph(){
	unordered_map<string, vector<pair<string, int>>>graph;
	unordered_map<string, vector<pair<string, int>>>::iterator it;
	cout << "Enter the Number of counteries" << endl;
	int num, num2;
	cin >> num;
	string name, name2;
	int distance;
	for (int i = 0; i < num; i++){
		cout << "Enter country" << i + 1 << " name" << endl;
		cin >> name;
		graph[name];
		cout << "Enter the Number of connected counteries" << endl;
		cin >> num2;
		for (int j = 0; j < num2; j++){
			cout << "Enter country" << j + 1 << " name" << endl;
			cin >> name2;
			cout << "Enter the distance between the tow counteries" << endl;
			cin >> distance;
			graph[name].push_back(make_pair(name2, distance));
		}

	}
	int count = 0;
	it = graph.begin();
	while (it != graph.end()){

		cout << "name  " << it->first << endl;
		while (count != it->second.size()){
			cout << "connected" << it->second[count].first << endl;
			cout << "distance" << it->second[count].second << endl;
			count++;
		}
		count = 0;
		it++;


	}
	return graph;
}
map<string, int> minDis(unordered_map<string, vector<pair<string, int>>> graph, int scr, string towns[6], map<string, int>cost, map <string, string>& pred)
{
	//cout <<" graph[towns[scr]].size() : " <<graph[towns[scr]].size() << endl; 
	vector<pair<string, int>>::iterator it;
	vector<pair<string, int>>::iterator it2;
	//unordered_map<string, vector<pair<string, int>>>::iterator itt;
	it = graph[towns[scr]].begin();
	it2 = graph[towns[scr]].begin();
	int i = 0;
	for (it = graph[towns[scr]].begin(); it != graph[towns[scr]].end(); it++)
	{

		if (it->second + cost[towns[scr]] < cost[it2->first])
		{
			cost[it2->first] = it->second + cost[towns[scr]];
			pred[it->first] = towns[scr];
		}
		i++;
		it2++;
	}
	return cost;
}

void adjes(unordered_map<string, vector<pair<string, int>>> graph)
{

}
int main()
{
	/*unordered_map<string, vector<pair<string, int>>>graph;
	unordered_map<string, vector<pair<string, int>>>::iterator it;*/
	/*graph["cairo"].push_back(make_pair("alex", 2));
	graph["cairo"].push_back(make_pair("tanta", 4));
	it = graph.begin();
	graph[it->second[0].first].push_back(make_pair("alminia", 4));
	graph[it->second[0].first].push_back(make_pair("borsaad", 2));
	graph[it->second[0].first].push_back(make_pair("tanta", 1));

	graph["tanta"].push_back(make_pair("borsaad", 3));

	graph["alminia"].push_back(make_pair("almansora", 2));

	graph["borsaad"].push_back(make_pair("alminia", 3));
	graph["borsaad"].push_back(make_pair("almansora", 2));*/
	cout << "add graph ";
	unordered_map<string, vector<pair<string, int>>>graph = add_graph();
	unordered_map<string, vector<pair<string, int>>>::iterator it;
	
	bool visited[6] = { false };
	int scr = 0;
	//string towns[6] /*= { "cairo", "alex", "tanta", "alminia", "borsaad", "almansora" }*/;
	string * towns=new string [graph.size()];
	int count = 0;
	for (it = graph.begin(); it != graph.end();it++){
		towns[count] = it->first;
		count++;
	}
	map <string, string>pred;
	map<string, int>cost;
	for (int i = 0; i < 6; i++)
	{
		cost[towns[i]] = INT_MAX;
	}
	cost[towns[scr]] = 0;
	map<string, int>::iterator it_again;
	for (int j = 0; j < 6; j++)
	{
		cost = minDis(graph, scr, towns, cost, pred);
		visited[scr] = true;
		int min = INT_MAX;
		int k;
		for (int i = 0; i < 6; i++)
		{
			if (cost[towns[i]] < min && !visited[i])
			{
				min = cost[towns[i]];
				k = i;
			}
		}
		scr = k;
	}
	string begin, end;
	cout << "enter begin then end : ";
	cin >> begin >> end;
	cout << "####################################################" << endl;
	stack<string>S;
	int CostOfSP = 0;
	string SS = pred[end];
	S.push(end);
	while (SS != begin)
	{
		S.push(SS);
		CostOfSP += cost[SS];
		SS = pred[SS];
	}
	S.push(begin);
	cout << "THE SHORTEST PATH IS : ";
	while (!S.empty())
	{
		cout << S.top() << endl;
		S.pop();
	}
	cout << "\n AND THE COST IS : " << CostOfSP << endl;
	for (int i = 0; i < 6; i++)
		cout << cost[towns[i]] << endl;
	map <string, string>::iterator op;
	for (op = pred.begin(); op != pred.end(); op++)
		cout << op->first << "\t" << op->second << endl;
	return 0;
}
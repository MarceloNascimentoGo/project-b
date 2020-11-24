import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:projectb_mobile/themes/color.dart';
import 'package:http/http.dart' as http;

class IndexPage extends StatefulWidget {
  @override
  _IndexPageState createState() => _IndexPageState();
}

class _IndexPageState extends State<IndexPage> {
  List users = [];
  bool isLoading = false;
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    this.fetchUser();
  }
  fetchUser() async {
    setState(() {
      isLoading = true;
    });
    var url = "http://10.0.2.2:5000/api/Pesquisa/query/lula";
    var response = await http.get(url);
    if(response.statusCode == 200){
      var items = json.decode(response.body);
      setState(() {
        users = items;
        isLoading = false;
      });
    }else{
      users = [];
      isLoading = false;
    }
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Project B"),
      ),
      body: getBody(),
    );
  }
  Widget getBody(){
    if(users.contains(null) || users.length < 0 || isLoading){
      return Center(child: CircularProgressIndicator(valueColor: new AlwaysStoppedAnimation<Color>(primary),));
    }
    return ListView.builder(
      itemCount: users.length,
      itemBuilder: (context,index){
      return getCard(users[index]);
    });
  }
  Widget getCard(item){
    var fullName = item['name'];
    var email = item['name'];
    var profileUrl = item['image']['thumbnail']['contentUrl'];
    return Card(
      elevation: 1.5,
      child: Padding(
        padding: const EdgeInsets.all(10.0),
        child: ListTile(
          title: Row(
            children: <Widget>[
              Container(
                width: 80,
                height: 80,
                decoration: BoxDecoration(
                  color: primary,
                  image: DecorationImage(
                    fit: BoxFit.cover,
                    image: NetworkImage(profileUrl)
                  )
                ),
              ),
              SizedBox(width: 20,),
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: <Widget>[
                  SizedBox(
                    width: MediaQuery.of(context).size.width-140,
                    child: Text(fullName,style: TextStyle(fontSize: 17),)),
                  SizedBox(height: 80,),
                  Text(email.toString(),style: TextStyle(color: Colors.grey),)
                ],
              )
            ],
          ),
        ),
      ),
    );
  }
}
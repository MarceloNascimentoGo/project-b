import 'dart:io';

import 'package:flutter/material.dart';
import 'package:projectb_mobile/pages/index.dart';
import 'package:projectb_mobile/themes/color.dart';

class MyHttpOverrides extends HttpOverrides{
  @override
  HttpClient createHttpClient(SecurityContext context){
    return super.createHttpClient(context)
      ..badCertificateCallback = (X509Certificate cert, String host, int port)=> true;
  }
}


void main(){
      HttpOverrides.global = new MyHttpOverrides();
      runApp( MaterialApp(
        debugShowCheckedModeBanner: false,
        theme: ThemeData(
          primaryColor: primary
        ),
        home: IndexPage(),
  ));
}
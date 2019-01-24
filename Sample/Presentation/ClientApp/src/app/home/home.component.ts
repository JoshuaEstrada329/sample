import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public messages: Message[];
  constructor(private http: HttpClient) {
    this.messages = [];

    this.CallMessages();
    
  }
  GetMessage() {
      this.http.get<Message>('http://localhost:58206/api/message').subscribe(result => {
      this.messages.push(result);
      console.log(result);
    });
  }

  CallMessages() {
    var i: number;
    for (i = 0; i <= 9; i++) {
      this.GetMessage();
    }
  }

}

interface Message {
  text: string;
}

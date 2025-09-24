import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit{
  protected readonly title = 'Dating App';
  protected members = signal<any>([]);
  /*
    zone less change detection for angular 20
   protected members = signal<any>([]); fine grained change detection
  */



  // Flow of component start: ctor -> component initialize using oninit interface
  // constructor(private http: HttpClient) { //Angular DI system way 1
  // }

  /*
   Angular DI system way 2 using inject()
   */
  private http = inject(HttpClient);

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/members').subscribe({
      next: (response)=> {
        this.members.set(response);
      },
      error: (error)=> {
        console.log(error);
      },
      complete: ()=> {
        console.log('completed request');
      }
    })
  }

  /*
  using promises and signals 

  async ngOnInit() {
    this.members.set(await this.getMembers());
  }


  async getMembers() {
    try {
      return lastValueFrom(this.http.get('https://localhost:5001/api/members'));
    }
    catch(error){
      console.log(error);
      throw error;
    }
  */
}

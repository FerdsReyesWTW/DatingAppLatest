import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  http = inject(HttpClient);
  title = 'client';
  users: any;

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/users').subscribe({
      next: (res) => {
        this.users = res;
      },
      error: (error) => {
        console.log(error);
      },
      complete: () => {
        console.log("completed");
      }
    })
  }
}

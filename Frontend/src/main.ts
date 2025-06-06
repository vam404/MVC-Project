import { bootstrapApplication } from '@angular/platform-browser';
import { Component } from '@angular/core';
import { provideHttpClient } from '@angular/common/http';
import { PostListComponent } from './app/components/product-list/product-list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [PostListComponent],
  template: `
    <div class="app-container">
      <nav class="navbar navbar-expand-lg navbar-dark bg-primary mb-4">
        <div class="container">
          <a class="navbar-brand">MVC App</a>
        </div>
      </nav>
      
      <main class="container mb-5">
        <app-product-list></app-product-list>
      </main>
      
      <footer class="bg-dark text-light py-4 mt-auto">
        <div class="container text-center">
          <p class="mb-0">© {{currentYear}}</p>
        </div>
      </footer>
    </div>
  `
})
export class App {
  currentYear = new Date().getFullYear();
}

bootstrapApplication(App, {
  providers: [
    provideHttpClient()
  ]
});
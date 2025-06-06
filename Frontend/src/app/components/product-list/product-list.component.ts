import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DataService } from '../../services/data.service';
import { Product } from '../../models/product.model';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './product-list.component.html',
  styles: []
})
export class PostListComponent implements OnInit {
  products: Product[] = [];
  loading = false;
  error = '';
  searchInput = '';

  constructor(private dataService: DataService) { }

  ngOnInit(): void {

  }

  loadProducts(): void {
    this.loading = true;
    this.error = '';
    
    if (!this.searchInput || this.searchInput.length == 0) {
      this.dataService.getAll().subscribe({
        next: (data) => {
          this.products = data;
          this.loading = false;
        },
        error: (err) => {
          this.error = err.message;
          this.loading = false;
        }
      });
    }
    else {
      this.dataService.getById(Number(this.searchInput)).subscribe({
        next: (data) => {
          this.products = [data];
          this.loading = false;
        },
        error: (err) => {
          this.error = err.message;
          this.loading = false;
        }
      });
    }
  }

  refreshData(): void {
    this.loadProducts();
  }
}
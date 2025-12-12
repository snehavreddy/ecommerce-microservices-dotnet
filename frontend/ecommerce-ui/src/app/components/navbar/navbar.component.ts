import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
currentUser$: any;

constructor(
  private authService: AuthService,
  private router: Router
) {
  this.currentUser$ = this.authService.currentUser$;
}

  logout(): void {
    this.authService.logout();
    this.router.navigate(['/login']);
  }
}
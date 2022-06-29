import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError, retry } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { Student } from './models/student';

@Injectable({
    providedIn: 'root',
  })
  export class RestApiService {
    // Define API
    apiURL = 'http://localhost:7109/api/student';
    constructor(private http: HttpClient) {}
    httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
      }),
    };
    
    getStudents(): Observable<Student> {
      return this.http
        .get<Student>(this.apiURL)
        .pipe(retry(1), catchError(this.handleError));
    }

    getStudent(id: any): Observable<Student> {
      return this.http
        .get<Student>(this.apiURL + id)
        .pipe(retry(1), catchError(this.handleError));
    }

    createStudent(employee: any): Observable<Student> {
      return this.http
        .post<Student>(
          this.apiURL,
          JSON.stringify(employee),
          this.httpOptions
        )
        .pipe(retry(1), catchError(this.handleError));
    }
  
    updateStudent(id: any, employee: any): Observable<Student> {
      return this.http
        .put<Student>(
          this.apiURL + id,
          JSON.stringify(employee),
          this.httpOptions
        )
        .pipe(retry(1), catchError(this.handleError));
    }

    deleteStudent(id: any) {
      return this.http
        .delete<Student>(this.apiURL + id, this.httpOptions)
        .pipe(retry(1), catchError(this.handleError));
    }

    handleError(error: any) {
      let errorMessage = '';
      if (error.error instanceof ErrorEvent) {
        // Get client-side error
        errorMessage = error.error.message;
      } else {
        // Get server-side error
        errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
      }
      window.alert(errorMessage);
      return throwError(() => {
        return errorMessage;
      });
    }
  }
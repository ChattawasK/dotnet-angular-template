import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class LeaveTypeService {

  constructor(private http: HttpClient) { }

  getAll(){
    return this.http.get('https://localhost:7167/api/LeaveTypes')
  }
}

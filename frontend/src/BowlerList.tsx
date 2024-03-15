import { useEffect, useState } from 'react';
import { bowler } from './types/bowler';
function BowlerList() {
  const [bowlerdata, setbowlerdata] = useState<bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5199/bowler');
      const f = await rsp.json();
      setbowlerdata(f);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowling League List</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Full Name:</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerdata.map((f) => (
            <tr key={f.bowlerId}>
              <td>{f.bowlerName}</td>
              <td>{f.address}</td>
              <td>{f.city}</td>
              <td>{f.state}</td>
              <td>{f.zip}</td>
              <td>{f.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;

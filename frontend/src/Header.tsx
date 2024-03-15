function Header() {
  return (
    <>
      <header
        className="row"
        style={{ backgroundColor: '#e0e0e0', padding: '20px' }}
      >
        <div className="col-4">
          <h1>Bowling League Database</h1>
        </div>
        <div className="col">
          <h3>
            This website that shows the bowlers in the bowling league and lists
            out their team and contact information. Please Enjoy!
          </h3>
        </div>
      </header>
    </>
  );
}

export default Header;

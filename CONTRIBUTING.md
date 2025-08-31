# Contributing to AspGoat

We welcome all contributions — from bug reports and code improvements to new labs and documentation.

### How to Contribute 🤝
1. **Fork & Clone**
   
   ```git clone https://github.com/Soham7-dev/AspGoat.git```
   
   ```cd AspGoat```

2. **Create a separate Branch**
   
   ```git checkout -b feature/add-graphql-lab```

3. **Test locally before raising a PR (using both .NET SDK and Docker)**

   ```dotnet restore```

   ```dotnet run```

   ```docker build -t aspgoat .```

   ```docker run --rm -p 8000:8000 aspgoat```

4. **Make Your Changes like the included Labs**

   - Keep code readable and commented
   - For new labs, include both vulnerable code and secure fix
  
5. **Push your code to your branch**

   ```git push origin feature/add-graphql-lab```

6. **Finally open a Pull Request (PR) to the main branch**

7. **Reporting Bugs**

   - Open an **Issue** with the **Bug** label
   - Provide Reproduction Steps
  
8. **Recognition**

   **All contributors will be credited in the Contributors section 🥳**
